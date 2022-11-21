using System;
using System.Collections.Generic;
using System.Text;

namespace LW_6
{
    class NonNegativeException : Exception
    {
        public NonNegativeException(string msg) : base(msg)
        {

        }
    }
}
