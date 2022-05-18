using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Spin
    {
        // field representing the spin
        private int wheelSpin;

        Random rand = new Random();

        // Constructor
        public Spin()
        {
            wheelSpin = 0;
        }

        // Spin Wheel method simulates contestant spin
        public void SpinWheel()
        {
            wheelSpin = rand.Next(9);
        } // end method

        public int GetSpin()
        {
            return wheelSpin;
        } // end method

        public int GetSpinValue()
        {
            switch(wheelSpin)
            {
                case 0:
                    return 100;
                case 1:
                    return 300;
                case 2:
                    return 500;
                case 3:
                    return 700;
                case 4:
                    return 900;
                case 5:
                    return 2000;
                case 6:
                    return 3000;
                case 7:
                    return 5000;
                case 8:
                    return -1000;
                case 9:
                    return 0;
                default:
                    return 0;
            }
        } // end method

    } // end class
} // end namespace
