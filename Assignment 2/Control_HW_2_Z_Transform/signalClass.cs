using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_HW_2_Z_Transform
{
    class inputSignal
    {
        /*
         * Class represents the input signal Object
         * Should be given the proper function that evaluates the output for different input values
         * Can be then accesed via the [] operator, which will handle -ve time [Causal sys]
         */

        string tag;
        int mag, freq, slope =1;

        public void init(string t,int m,int f,int s)
        {
            tag = t;
            mag = m;
            freq = f;
            slope = s;
        }

        public double this[double indx]{
            get{
                if (indx < 0)
                    return 0;
                else
                    switch (tag)
                    {
                        case "Step":
                            return mag;
                        case "Sin":
                            return mag*Math.Sin(2*Math.PI* freq*indx);
                        case "Ramp":
                            return slope * indx;
                        case "Impulse":
                            if (indx == 0) return mag;
                            else return 0;
                        default:
                            break;
                    }
                return 0;
            }
        }
    }
}
