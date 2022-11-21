using System;

namespace LW_4
{
    public class Confectionery : Commodity
    {
        public sbyte Type { get; set; }
        public int PercentageOfSugar { get; set; }


        public Confectionery(sbyte type, int percentageOfSugar,
            int weight, string name, string releaseDate, int guaranteePeriod,
            int price = 0, int ageLimit = 0, int discount = 0, bool isExist = false) : 
            base(weight, name, releaseDate, guaranteePeriod, price, ageLimit, discount, isExist)
        {
            Type = type;
            if (type > 1 || type < 0)
                throw new LW_6.ConfectioneryTypeException("Type can't be > 1, or < 0");

            PercentageOfSugar = percentageOfSugar;
        }
    }
}
