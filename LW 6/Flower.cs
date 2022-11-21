using System;
using System.Collections.Generic;
using System.Text;

namespace LW_4
{
    class Flower : Product
    {
        public Flower(int weight, string name, string releaseDate, int guaranteePeriod) :
            base(weight, name, releaseDate, guaranteePeriod)
        { }
        
    }
}
