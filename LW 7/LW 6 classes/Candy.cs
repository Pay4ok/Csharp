using System;
using System.Collections.Generic;
using System.Text;

namespace LW_4
{
    public class Candy : Confectionery
    {
        public Candy(sbyte type, int percentageOfSugar,
            int weight, string name, string releaseDate, int guaranteePeriod,
            int price = 0, int ageLimit = 0, int discount = 0, bool isExist = false) : 
            base(type, percentageOfSugar, weight, name, releaseDate, guaranteePeriod, price, ageLimit, discount, isExist)
        {}
    }
}
