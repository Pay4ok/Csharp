using System;
using System.Collections.Generic;
using System.Text;

namespace LW_4
{
    public class Commodity : Product
    {
        public int Price { get; set; }
        public int AgeLimit { get; set; }
        public int Discount { get; set; }
        public bool IsExist { get; set; }

        public Commodity(int weight, string name, string releaseDate, int guaranteePeriod,
            int price = 0, int ageLimit = 0, int discount = 0, bool isExist = false) :
            base(weight, name, releaseDate, guaranteePeriod)
        {
            Price = price;
            AgeLimit = ageLimit;
            Discount = discount;
            IsExist = isExist;
        }
    }
}
