using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubcarrierAllocation2
{
    [Serializable()]	
    public class DataToXML
    {
        public List<Solution> combinedSolutions { get; set; }

        public List<int> nrOfUsersToStation;

        public int nrOfRelays;

        public DataToXML() // parametry, które trzeba zapisać
        {
            combinedSolutions = new List<Solution>();
            nrOfUsersToStation = new List<int>();
        }

    }
}
