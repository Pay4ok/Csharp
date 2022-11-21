using System;
using System.Collections.Generic;
using System.Text;

namespace LW_6
{
    class LengthOutOfRangeException : Exception
    {
        public LengthOutOfRangeException() : base()
        {
            Console.WriteLine("Length too long, max length is 100!");
        }
    }
}
