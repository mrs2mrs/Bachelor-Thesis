using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubcarrierAllocation2
{
    [Serializable()]
    class PRB
    {
        public List<Subcarrier> AvailableSubcarriers;

        public int ID;

        public PRB(int id)
        {
            ID = id;
            AvailableSubcarriers = new List<Subcarrier>(12);
            Random rand = new Random();
            for (int i = 0; i < 12; ++i)
            {
                AvailableSubcarriers.Add(new Subcarrier());
                AvailableSubcarriers[i].AWGNdirect = (float)SystemModel.gaussianRandom(rand, 0.0f, 8.0f);
                AvailableSubcarriers[i].AWGNbackhaul = (float)SystemModel.gaussianRandom(rand, 0.0f, 6.0f);
                AvailableSubcarriers[i].AWGNrelay = (float)SystemModel.gaussianRandom(rand, 0.0f, 10.0f);
            }
        }


        

        


  

        
    }
}
