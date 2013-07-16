using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubcarrierAllocation2
{
    class RelayStation : Station
    {
        public int ID;

        public int demand;

        public int currentAvailableBitsToSend;

        public float pathLoss; // !!!!!!!!!!!!!!!!!!!!!!!!

        private int referenceNoise = -79;

        public List<LocalPRBusage> fromBaseStation = new List<LocalPRBusage>();

        public RelayStation(Point _pos, int id, float _pathloss)
            : base(_pos, id)
        {
          pathLoss = _pathloss;
        }

        public void clearDemand()
        {
            demand = 0;
        }



        public int calculateSpeed()
        {
            float effBeta = chooseBetaFactor(MSC.QAM16_1_2);

            float beta = 0; // calculated, effective Beta param

            while (beta != effBeta)
            {
                beta = effBeta;
                float snrEff = 0;
                foreach (LocalPRBusage local in fromBaseStation)
                {

                    foreach (Subcarrier subcarrier in local.prb.AvailableSubcarriers)
                    {
                        float snr = subcarrier.signalpower;
                        snr -= local.interference;
                        snr -= this.pathLoss;
                        snr -= subcarrier.getAWGN(SystemModel.connectionType.backhaul);
                        snr -= referenceNoise;
             //           Console.WriteLine(" SNR " + snr);
                        snrEff += (float)Math.Exp(-(snr / beta));
                    }
                }
                snrEff /= (fromBaseStation.Count * 12);
                snrEff = (float)Math.Log(Math.E, snrEff);
                snrEff *= -beta;
         //       Console.WriteLine("SNR EFF " + snrEff);
                effBeta = chooseBetaFactor(chooseMSC(snrEff));
            }
            return speedBasedOnMSC(chooseMSC(effBeta));


        }

        private float chooseBetaFactor(MSC mcs)
        {
            switch (mcs)
            {
                case MSC.QPSK_1_3:
                    return 1.49f;
                case MSC.QPSK_1_2:
                    return 1.57f;
                case MSC.QPSK_2_3:
                    return 1.69f;
                case MSC.QPSK_3_4:
                    return 1.69f;
                case MSC.QPSK_4_5:
                    return 1.65f;
                case MSC.QAM16_1_2:
                    return 4.56f;
                case MSC.QAM16_2_3:
                    return 6.42f;
                case MSC.QAM16_3_4:
                    return 7.33f;
                case MSC.QAM16_4_5:
                    return 7.68f;
                case MSC.QAM64_2_3:
                    return 20.57f;
                case MSC.QAM64_3_4:
                    return 25.16f;
                case MSC.QAM64_4_5:
                    return 28.38f;
                default:
                    return 1.49f;
            }
        }

        public enum MSC { QPSK_1_3, QPSK_1_2, QPSK_2_3, QPSK_3_4, QPSK_4_5, QAM16_1_2, QAM16_2_3, QAM16_3_4, QAM16_4_5, QAM64_2_3, QAM64_3_4, QAM64_4_5 };

        public MSC chooseMSC(float snr)
        {
            if (snr <= 1.5)
                return MSC.QPSK_1_3;
            if (snr <= 3.8)
                return MSC.QPSK_1_2;
            if (snr <= 5.2)
                return MSC.QPSK_2_3;
            if (snr <= 5.9)
                return MSC.QPSK_3_4;
            if (snr <= 7.0)
                return MSC.QPSK_4_5;
            if (snr <= 10.0)
                return MSC.QAM16_1_2;
            if (snr <= 11.4)
                return MSC.QAM16_2_3;
            if (snr <= 12.3)
                return MSC.QAM16_3_4;
            if (snr <= 15.6)
                return MSC.QAM16_4_5;
            if (snr <= 17.0)
                return MSC.QAM64_2_3;
            if (snr <= 18.0)
                return MSC.QAM64_3_4;
            return MSC.QAM64_4_5;
        }



        public int speedBasedOnMSC(MSC msc)
        {
            switch (msc)
            {
                case MSC.QPSK_1_3:
                    {
                        currentAvailableBitsToSend += 224;
                        return 224;
                    }
                case MSC.QPSK_1_2:
                    {
                        currentAvailableBitsToSend += 336;
                        return 336;
                    }
                case MSC.QPSK_2_3:
                    {
                        currentAvailableBitsToSend += 448;
                        return 448;
                    }
                case MSC.QPSK_3_4:
                    {
                        currentAvailableBitsToSend += 504;
                        return 504;
                    }
                case MSC.QPSK_4_5:
                    {
                        currentAvailableBitsToSend += 538;
                        return 538;
                    }
                case MSC.QAM16_1_2:
                    {
                        currentAvailableBitsToSend += 1344;
                        return 1344;
                    }
                case MSC.QAM16_2_3:
                    {
                        currentAvailableBitsToSend += 1792;
                        return 1792;
                    }
                case MSC.QAM16_3_4:
                    {
                        currentAvailableBitsToSend += 2016;
                        return 2016;
                    }
                case MSC.QAM16_4_5:
                    {
                        currentAvailableBitsToSend += 2150;
                        return 2150;
                    }
                case MSC.QAM64_2_3:
                    {
                        currentAvailableBitsToSend += 7168;
                        return 7168;
                    }
                case MSC.QAM64_3_4:
                    {
                        currentAvailableBitsToSend += 8064;
                        return 8064;
                    }
                case MSC.QAM64_4_5:
                    {
                        currentAvailableBitsToSend += 8602;
                        return 8602;
                    }
                default:
                    {
                        currentAvailableBitsToSend = +1344;
                        return 1344;
                    }
            }
        }
    }
}
