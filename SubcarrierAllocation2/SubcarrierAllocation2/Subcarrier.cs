using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubcarrierAllocation2
{
    [Serializable()]
    class Subcarrier
    {
        public Subcarrier() { }

        public float bandwidth = 15000; // Hz
        
        public float signalpower = 16; // [mW, 15.2107 dBm] !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        
        public float AWGNdirect;

        public float AWGNbackhaul;

        public float AWGNrelay;

        public float getAWGN(SystemModel.connectionType connection)
        {
            switch (connection)
            {
                case SystemModel.connectionType.backhaul :
                    return AWGNbackhaul;
                case SystemModel.connectionType.direct :
                    return AWGNdirect;
                case SystemModel.connectionType.relay :
                    return AWGNrelay;
                default:
                    return AWGNdirect;
            }
        }

        public dB getSNRdB()
        {
            return new dB((float)(10 * Math.Log10(getSNR())));
        }

        public float getSNR()
        {
            return signalpower / (AWGNdirect + 1);
        }
    }
}
