using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussines_logik
{
    public class Stat
    {
        public int Current;
        public int Max;

        public Stat(int initialMax)
        {
            if (initialMax < 1)
            {
                initialMax = 1;
            }

            Max = initialMax;
            Current = initialMax;
        }

        public void ModifyCurrent(int amount)
        {
            Current = Current + amount;

            if (Current > Max)
            {
                Current = Max;
            }

            if (Current < 0)
            {
                Current = 0;
            }
        }

        public void ModifyMax(int amount)
        {
            Max = Max + amount;

            if (Max < 1)
            {
                Max = 1;
            }

            if (Current > Max)
            {
                Current = Max;
            }
        }
    }
}