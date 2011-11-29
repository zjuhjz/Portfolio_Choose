using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Portfolio_Choose
{
    class DemandItem
    {
        bool[] risk;
        bool[] fluidity;
        int ratio;
        public int group;
        
        public void setRisk(bool a0, bool a1, bool a2, bool a3)
        {
            risk[0] = a0;
            risk[1] = a1;
            risk[2] = a2;
            risk[3] = a3;
        }

        public void setFluidity(bool a0, bool a1, bool a2)
        {
            fluidity[0] = a0;
            fluidity[1] = a1;
            fluidity[2] = a2;
        }
        public void setRatio(int ratio)
        {
            this.ratio = ratio;
        }

        public bool getRisk(int i)
        {
            if (i > 3) return false;
            return risk[i];
        }

        public bool getFluidity(int i)
        {
            if (i > 2) return false;
            return fluidity[i];
        }

        public int getRatio()
        {
            return ratio;
        }
        public DemandItem()
        {
            risk = new bool[4];
            fluidity = new bool[3];
            ratio = 0;
            risk[0] = false;
            risk[1] = false;
            risk[2] = false;
            risk[3] = false;
            fluidity[0] = false;
            fluidity[1] = false;
            fluidity[2] = false;
        }
    }
    
}
