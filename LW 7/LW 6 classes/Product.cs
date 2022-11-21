using System;
using System.Collections.Generic;
using System.Text;

namespace LW_4
{
    public class Product
    {
        public int Weight { get; set; }
        public string Name { get; set; }
        public string ReleaseDate { get; set; }
        public int GuaranteePeriod { get; set; }

        public Product(int weight, string name, string releaseDate, int guaranteePeriod)
        {
            Weight = weight;
            Name = name;
            if (Name.Length > 100)
                throw new LW_6.LengthOutOfRangeException();
            ReleaseDate = releaseDate;
            GuaranteePeriod = guaranteePeriod;
            if (GuaranteePeriod < 0)
                throw new LW_6.NonNegativeException("Guarantee period can't be negative!");
        }

        public override bool Equals(object obj)
        {
            return this.Name == ((Product)obj).Name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Name: {Name}, Weight: {Weight}, ReleaseDate: {ReleaseDate}, GuaranteePeriod: {GuaranteePeriod}";
        }
    }
}
