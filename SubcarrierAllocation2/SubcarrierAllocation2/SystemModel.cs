using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubcarrierAllocation2
{
    class Point
    {
        public float X;
        public float Y;

        public Point() { }

        public Point(float _x, float _y)
        {
            X = _x;
            Y = _y;
        }
        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
        }
        public double Distance(Point p)
        {
            return Math.Sqrt(Math.Pow(p.X - this.X, 2) + Math.Pow(p.Y - this.Y, 2));
        }

        public static Point operator*(Point p, float factor)
        {
            return new Point(p.X * factor, p.Y * factor);
        }
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }
    }

    class SystemModel
    {
        // system model
        public int numberOfUsers;
        public int userDemand;
        public int cellRadius;
        public int numberOfRelays;
        public float distanceProportion;
        public int freqReuseFactor;
        public int nrOfPRB;

        // simulated annealing
        public int temperature;
        public float decrease;
        public int stepsUnchangedTemperature;
        public int insignificantChange;
        public float stepsInsignificant;
        public string destination;
        // supporting 
        public enum connectionType { direct, relay, backhaul };

        // containers
        public List<User> userList;
        public List<Station> stationList;
        public BaseStation baseStation;
        public List<PRB> PRBlist;
        public DataToXML dataToXML;

        public SystemModel(int _userNumber, int _userDemand, int _cellSize, int _relaysNr, float _distanceProp, int _freqReuseFactor, int _PRBnr,
                            int _temperature, float _decrease, int _stepsUnchangedTemperature, int _insignificantChange, float _stepsInsignificant, string _destination)
        {
            numberOfUsers = _userNumber;
            userDemand = _userDemand;
            cellRadius = _cellSize;
            numberOfRelays = _relaysNr;
            distanceProportion = _distanceProp;
            userList = new List<User>(numberOfUsers);
            stationList = new List<Station>(_relaysNr + 1);
            baseStation = new BaseStation(new Point(cellRadius, cellRadius));
            stationList.Add(baseStation);
            freqReuseFactor = _freqReuseFactor;
            nrOfPRB = _PRBnr;
            temperature = _temperature;
            decrease = _decrease;
            stepsUnchangedTemperature = _stepsUnchangedTemperature;
            insignificantChange = _insignificantChange;
            stepsInsignificant = _stepsInsignificant;
            destination = _destination;
            destination += "\\output.xml";
            dataToXML = new DataToXML();
            randomedInitialize();
            assignPRBtoUsers();

        }

        public void Simmulate()
        {
            
            float currentTemperature = temperature;
            int steps = 0;
            int insignificant = 0;
            Solution bestSolution;
            assignPRBtoUsers();
            bestSolution = saveSolution("initial solution");
            dataToXML.combinedSolutions.Add(bestSolution);
            float maxEnergy = totalSpeed();
      //      Console.WriteLine("Simmulated Anealing " + maxEnergy);
            float currentEnergy = 0;
            float previousEnergy = 0;
            Random rand = new Random();
            while (currentTemperature > 0)
            {
                ++steps;
                step();
                currentEnergy = totalSpeed();
                float delta = previousEnergy - currentEnergy;
                if (Math.Exp(-delta / currentTemperature) > rand.NextDouble())
                {
                    bestSolution = saveSolution("best solution");
                    steps = 0;
                }
                if ((delta / previousEnergy) * 100 < insignificantChange)
                {
                    ++insignificant;
                }
                if (insignificant > stepsInsignificant)
                {
                    break;
                }
                previousEnergy = currentEnergy;
                Console.WriteLine("Simmulated Anealing " + currentEnergy);
                
                if (steps == stepsUnchangedTemperature)
                {
                    currentTemperature *= decrease; // cooling scheme
                }
            }
            Console.WriteLine("FTW");
            XmlSerializer.Serialize<DataToXML>(destination, dataToXML);    //    TO DO !!!!!
        }

        public void step()
        {
            freeRandomPRB();
            assignPRBtoUsers();

        }

        public int totalSpeed()
        {
            int ret = 0;
            foreach (User user in userList)
            {
                ret += user.currentAvailableBitsToSend;
            }
            return ret;
        }

        public void InitializeSimmulatedAnnealing()
        {
            
        }

        public void assignPRBtoUsers()
        {
            Random rand = new Random();
            // assign PRB without concerning interference between them
            foreach (User user in userList)
            {
                RelayStation assignedRelay = user.assignedStation as RelayStation;
                // for user assigned to relays prbs between BS and RS has to be assigned
                if (null != assignedRelay)
                {
          //          Console.WriteLine(user.ID + " user assigned to RS, current " + user.currentAvailableBitsToSend);
                    List<PRB> availableFromBaseStation = getUnusedPRBfromStation(baseStation);
                    List<PRB> available = getUnusedPRBfromStation(user.assignedStation);
                    while (available.Count > 0 && user.demand > user.currentAvailableBitsToSend)
                    {
                        int index = rand.Next(available.Count);
                        PRB prb = available[index];
                        available.RemoveAt(index);
                        user.fromStation.Add(new LocalPRBusage(prb));
                        assignedRelay.demand += user.calculateSpeed();
        //                Console.WriteLine("current " + user.currentAvailableBitsToSend);
                        assignPRBtoRelay(assignedRelay, availableFromBaseStation);
                        calculateInterferenceForPRB(prb);
                        clearRelayDemands();
                        updateRelayDemands();
                    }
                    assignPRBtoRelay(assignedRelay, availableFromBaseStation);
                }
                else // assinged station is BS
                {
      //              Console.WriteLine(user.ID + " user assigned to BS, current " + user.currentAvailableBitsToSend);
                    List<PRB> available = getUnusedPRBfromStation(baseStation);
                    while (available.Count > 0 && user.demand > user.currentAvailableBitsToSend)
                    {
                        int index = rand.Next(available.Count);
                        PRB prb = available[index];
                        available.RemoveAt(index);
                        user.fromStation.Add(new LocalPRBusage(prb));
                        user.calculateSpeed();
        //                Console.WriteLine("current " + user.currentAvailableBitsToSend);
                        calculateInterferenceForPRB(prb);
                        clearRelayDemands();
                        updateRelayDemands();
                    }
                }
            }
        }

        private void assignPRBtoRelay(RelayStation relay, List<PRB> availableFromBaseStation)
        {
            Random rand = new Random();
            while (availableFromBaseStation.Count > 0 && relay.demand > relay.currentAvailableBitsToSend)
            {
                int index = rand.Next(availableFromBaseStation.Count);
         //       Console.WriteLine(relay.ID + " Relay, demand " + relay.demand);
                PRB BSprb = availableFromBaseStation[index];
                availableFromBaseStation.RemoveAt(index);
                relay.fromBaseStation.Add(new LocalPRBusage(BSprb));
                relay.calculateSpeed();
        //        Console.WriteLine("current " + relay.currentAvailableBitsToSend);
            }
        }


        public void freeRandomPRB()
        {
            PRB prb;
            for (prb = tryFreeRandomPRB(); prb == null; prb = tryFreeRandomPRB() )
            {}
            calculateInterferenceForPRB(prb);
        }

        public PRB tryFreeRandomPRB()
        {
            Random rand = new Random();
            int value = rand.Next(2);
            switch (value)
            {
                case 0:
                    {
                        if (stationList.Count > 1)
                        {
                            int relayIndex = rand.Next(1,stationList.Count);
                            RelayStation relay = ((RelayStation)stationList[relayIndex]);
                            if (relay.fromBaseStation.Count > 0)
                            {
                                int prbIndex = rand.Next(relay.fromBaseStation.Count);
                                PRB prb = relay.fromBaseStation[prbIndex].prb;
                                relay.fromBaseStation.RemoveAt(prbIndex);

                                return prb;
                            }
                        }
                        break ;
                    }
                case 1:
                    {
                        int userIndex = rand.Next(userList.Count);
                        User user = userList[userIndex];
                        if (user.fromStation.Count > 0)
                        {
                            int prbIndex = rand.Next(user.fromStation.Count);
                            PRB prb = user.fromStation[prbIndex].prb;
                            user.fromStation.RemoveAt(prbIndex);
                            return prb;
                        }
                        break;
                    }
            }
            return null;

        }

        public void calculateInterference()
        {
            foreach (PRB prb in PRBlist)
            {
                calculateInterferenceForPRB(prb);
            }
        }


        public void clearRelayDemands()
        {
            for (int i = 1; i < stationList.Count; ++i)
            {
                ((RelayStation)stationList[i]).clearDemand();
            }
        }

        

        public void updateRelayDemands()
        {
            foreach (User user in userList)
            {
                RelayStation assignedRelay = user.assignedStation as RelayStation;
                
                if (null != assignedRelay)

                    assignedRelay.demand += user.currentAvailableBitsToSend;
            }
        }

        public void calculateInterferenceForPRB(PRB prb)
        {
            List<dataForPRBinterferenceCalculation> list = gatherInterferingPRB(prb);
            foreach (dataForPRBinterferenceCalculation data in list)
            {
                data.localPrb.interference = 0;
                foreach (dataForPRBinterferenceCalculation dataRef in list)
                {
                    if (!(dataRef.betweenBSandRS) && data != dataRef)
                    {
                        data.localPrb.interference += calculatePathLoss(data.receive.Distance(dataRef.transmit));
                    }
                }
            }
        }

        

        

        public List<dataForPRBinterferenceCalculation> gatherInterferingPRB(PRB prb)
        {
            List<dataForPRBinterferenceCalculation> ret = new List<dataForPRBinterferenceCalculation>();
            foreach (User user in userList)
            {
                foreach (LocalPRBusage local in user.fromStation)
                {
                    if (local.prb == prb)
                        ret.Add(new dataForPRBinterferenceCalculation(user.assignedStation.position, user.position, local, false));
                }
            }
            for (int i = 1; i < stationList.Count; ++i)
            {
                foreach (LocalPRBusage local in ((RelayStation)stationList[i]).fromBaseStation)
                {
                    if (local.prb == prb)
                        ret.Add(new dataForPRBinterferenceCalculation(baseStation.position, stationList[i].position, local, true));
                }
            }
                return ret;
        }

        public class dataForPRBinterferenceCalculation
        {
            public bool betweenBSandRS;
            public LocalPRBusage localPrb;
            public Point transmit;
            public Point receive;
            public dataForPRBinterferenceCalculation(Point _t, Point _r, LocalPRBusage _loc, bool _flag)
            {
                transmit = _t;
                receive = _r;
                localPrb = _loc;
                betweenBSandRS = _flag;
            }
        }

        public List<User> getUsersAssignedToStation(Station station)
        {
            List<User> ret = new List<User>();
            foreach (User element in userList)
            {
                if (element.assignedStation == station)
                    ret.Add(element);
            }
            return ret;
        }

        public List<PRB> getUnusedPRBfromStation(Station station)
        {
            List<PRB> ret = new List<PRB>(station.ownedPRB);
            List<User> usersFromStation = getUsersAssignedToStation(station);
            foreach (User element in usersFromStation)
            {
                foreach (LocalPRBusage prb in element.fromStation)
                {
                    ret.Remove(prb.prb);
                }
            }
            if (station == baseStation)
            {
                for (int i = 1; i < stationList.Count; ++i )
                {
                    foreach (LocalPRBusage prb in ((RelayStation)stationList[i]).fromBaseStation)
                    {
                        ret.Remove(prb.prb);
                    }
                }
            }
            return ret;
        }

        public void randomedInitialize()
        {
            if (numberOfUsers > 0)
            {
                placeUsers();
                //checkUsers();
            }
            if (numberOfRelays != 0)
            {
                placeRelays();
                //check();
                assignUsersToRelays();
      //          checkUserAssignment();
            }
            else
            {
                assignUsersToBase();
        //        checkUserAssignment();
            }

            //Console.WriteLine("SORTED");
            userList.Sort(delegate(User u1, User u2) { return u1.CompareTo(u2); });
            assignIDtoUsers();
           // checkUsers();

            PRBlist = new List<PRB>(nrOfPRB);
            for (int i = 0; i < nrOfPRB; ++i)
            {
                PRBlist.Add(new PRB(i));
            }

            switch (freqReuseFactor)
            {
                case 0:     // each sector has equal portion of bandwidth
                    {
                        int offset = nrOfPRB % (numberOfRelays + 1);
                        for (int i = 0; i < offset; ++i)
                        {
                            baseStation.ownedPRB.Add(PRBlist[i]);
                          //  Console.WriteLine(baseStation.ToString() + " PRB id " + PRBlist[i]);
                        }
                        int offset2 = (nrOfPRB - offset) / (numberOfRelays + 1);
                        int iterator = (offset > 0) ? offset : 0;
                        for (int i = 0; i < stationList.Count; ++i)
                        {
                            for (int j = iterator; j < (iterator + offset2); ++j)
                            {
                                stationList[i].ownedPRB.Add(PRBlist[j]);
                            }
                            iterator += offset2;
                        }
                        //checkPRBassignment();
                        break;
                    }
                case 1:  // each sector has full bandwidth
                    {
                        foreach (Station sta in stationList)
                        {
                            foreach (PRB prb in PRBlist)
                            {
                                sta.ownedPRB.Add(prb);
                            }
                        }
                //        checkPRBassignment();
                        break;
                    }
                default:
                    break;
            }
            //saveSolution();
        }


        private void placeRelays()
        {

            float angle = (float)(2 * Math.PI / numberOfRelays);
            float r = ((cellRadius * distanceProportion) > 40) ? (cellRadius * distanceProportion) : 10;
            for (int i = 0; i < numberOfRelays; ++i)
            {
                float currentAngle = angle * i;
                Point p = angleToNormalizedVector(currentAngle) * r;
                Point position = p + baseStation.position;
                stationList.Add(new RelayStation(position, i+1, calculatePathLoss(position.Distance(baseStation.position))));
            }
           // check();


        }

        private Point angleToNormalizedVector(float angle)
        {
            return new Point((float)Math.Cos(angle), (float)Math.Sin(angle));
        }


        private void placeUsers()
        {
            Random rand = new Random();
            for (int i = 0; i < numberOfUsers; ++i)
            {
                Point position = new Point(0, 0);
                while (!isPointInside(position))
                {
                    position.X = (float)rand.NextDouble() * 2 * cellRadius;
                    position.Y = (float)rand.NextDouble() * 2 * cellRadius;
                }
                userList.Add(new User(position, userDemand));
            }
        }

        private bool isPointInside(Point p)
        {
            if (p.Distance(baseStation.position) > cellRadius)
                return false;
            return true;
        }

        public void evalTwoNearestRelays(User userEq, RelayStation[] ret)
        {
            ret[0] = null;
            double distance0 = 0;
            ret[1] = null;
            double distance1 = 0;
            for (int i = 1; i < stationList.Count; ++i )
            {
                if (0 == distance0 || userEq.position.Distance(stationList[i].position) < distance0)
                {
                    ret[0] = (RelayStation)stationList[i];
                    distance0 = userEq.position.Distance(stationList[i].position);
                    //break;
                }
                if (0 == distance1 || userEq.position.Distance(stationList[i].position) < distance1)
                {
                    ret[1] = (RelayStation)stationList[i];
                    distance1 = userEq.position.Distance(stationList[i].position);
                    //break;
                }
            }
            return;
        }

        public void assignUsersToRelays()
        {
            Random rand = new Random();
            foreach (User element in userList)
            {
                float minPathLoss = 0;
                Station assigned;
                RelayStation[] closest = new RelayStation[2];
                evalTwoNearestRelays(element, closest);
                minPathLoss = calculatePathLoss(element.position.Distance(baseStation.position));
                assigned = baseStation;
                if (calculatePathLoss(element.position.Distance(closest[0].position)) < minPathLoss)
                {
                    minPathLoss = calculatePathLoss(element.position.Distance(closest[0].position));
                    assigned = closest[0];
                }
                if (closest[1] != null && calculatePathLoss(element.position.Distance(closest[1].position)) < minPathLoss)
                {
                    minPathLoss = calculatePathLoss(element.position.Distance(closest[1].position));
                    assigned = closest[1];
                }
                element.pathLoss = minPathLoss;
                element.assignedStation = assigned;
                if (assigned is BaseStation)
                    element.connectionType = SystemModel.connectionType.direct;
                else
                    element.connectionType = SystemModel.connectionType.relay;
   //             Console.WriteLine(assigned.ToString());
   //             Console.WriteLine(minPathLoss);
                
            }
        }

        public void assignUsersToBase()
        {
            Random rand = new Random();
            foreach (User element in userList)
            {
                element.pathLoss = calculatePathLoss(element.position.Distance(baseStation.position));
                element.assignedStation = baseStation;
            }
        }

        public void assignIDtoUsers()
        {
            int id = 0;
            foreach (User element in userList)
            {
                element.pathLoss = calculatePathLoss(element.position.Distance(baseStation.position));
                element.ID = id++;
            }
        }

        public void saveSimmulationParams()
        {
            this.dataToXML.nrOfRelays = numberOfRelays;
        }

        public void saveUsersAttachedToStations()
        {
            List<int> attachment = new List<int>(stationList.Count);
            foreach (User user in userList)
            {
                attachment[user.assignedStation.ID]++;
            }
            dataToXML.nrOfUsersToStation = attachment;
        }

        public Solution saveSolution(String str)
        {
            Solution sol = new Solution(numberOfRelays, numberOfUsers, str);
            for (int i = 1; i < stationList.Count; ++i)
            {
                RelaySolution relSol = new RelaySolution(i);
                foreach (LocalPRBusage prb in ((RelayStation)stationList[i]).fromBaseStation)
                {
                    relSol.PRBs.Add(prb.prb.ID);
                }
                sol.relaySolutions.Add(relSol);
            }
            for (int i = 0; i < userList.Count; ++i)
            {
                UserSolution userSol = new UserSolution(i);
                foreach (LocalPRBusage prb in userList[i].fromStation)
                {
                    userSol.PRBs.Add(prb.prb.ID);
                }
                sol.userSolutions.Add(userSol);
            }
            return sol;
        }

        public static double gaussianRandom(Random rand, float mean, float stdDev)
        {
            double u1 = rand.NextDouble(); //these are uniform(0,1) random doubles
            double u2 = rand.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
            Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
            return mean + stdDev * randStdNormal; //random normal(mean,stdDev^2)
        }

        public float calculatePathLoss(double distance)
        {
            double pathloss = 95.5 + 34.1 * Math.Log10(distance / 1000);
          //  Console.WriteLine((float)pathloss);
            return (float)pathloss;
        }



        private void check()
        {
            Console.WriteLine("relays positions check");
            foreach (Station elem in stationList)
            {
                Console.WriteLine("Pos: x " + elem.position.X + " y " + elem.position.Y);
            }
            Console.WriteLine("/relays positions check");
        }
        private void checkUsers()
        {
            foreach (User elem in userList)
            {
                Console.WriteLine("ID " + elem.ID + " pathloss: " + elem.pathLoss);
                //Console.WriteLine("Pos: x " + elem.position.X + " y " + elem.position.Y);
            }
        }
        private void checkUserAssignment()
        {
            int rel = 0; 
            int bas = 0;
            int uns = 0;
            foreach (User elem in userList)
            {

                if (elem.assignedStation == stationList[0])
                {
                    Console.WriteLine("bazowa");
                    bas++;
                }
                if (stationList.Count > 2)
                {
                    if (elem.assignedStation == stationList[1] || elem.assignedStation == stationList[2])
                    {
                        Console.WriteLine("relay?");
                        rel++;
                    }
                }
                if (elem.assignedStation == null)
                {
                    Console.WriteLine("nieprzyp");
                    uns++;
                }
            }
            Console.WriteLine("rel: " + rel + " baz: " + bas + " niep: " + uns);
        }

        public void checkPRBassignment()
        {
            foreach(Station sta in stationList)
            {
                foreach (PRB prb in sta.ownedPRB)
                {
                    Console.WriteLine(sta.ToString() + " PRB id " + prb.ID);
                }
            }
        }
    }
}
