using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubcarrierAllocation2
{
    class dB
    {
        private float value;

        public float Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public dB(float _value)
        {
            value = _value;
        }

        public float mW()
        {
            return (float)Math.Pow(10, value / 10) / 1000;
        }

        public static bool operator <(dB c1, double c2)
        {
            return c1.value < c2;
        }

        public static bool operator >(dB c1, double c2)
        {
            return c1.value > c2;
        }
        public static bool operator <=(dB c1, double c2)
        {
            return c1.value <= c2;
        }
        public static bool operator >=(dB c1, double c2)
        {
            return c1.value >= c2;
        }

        //  public dB mW2dB(float mW)
        //  {
        //      return new dB(10*Math.Log10(mW));
        //   }

        public static dB snr2dB(float snr)
        {
            return new dB((float)(10 * Math.Log10(snr)));
        }
    }
}

