using System;
using System.Collections.Generic;
using System.Text;

namespace LW_4
{
    class Clock : Product
    {
        public Clock(int weight, string name, string releaseDate, int guaranteePeriod) :
            base(weight, name, releaseDate, guaranteePeriod)
        { }

    }
}
