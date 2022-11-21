using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_6
{
    public class ConfectioneryTypeException : Exception
    {
        public ConfectioneryTypeException(string msg) : base(msg)
        {
        } 
    }
}