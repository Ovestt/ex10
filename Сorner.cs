using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    class Corner
    {
        decimal gradus;
        decimal min;
        int sec;
        public decimal Gradus
        {
            set
            {
                gradus = value % 360;
            }
            get
            {
                return gradus;
            }
        }
        public decimal Min
        {
            set
            {
                Gradus += value / 60;
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                Gradus += value / 3600;
            }
            get
            {
                return sec;
            }
        }
        public Corner(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        public decimal ToRadius()
        {
            return Convert.ToDecimal(Math.PI) * gradus / 180;
        }
    }
}
