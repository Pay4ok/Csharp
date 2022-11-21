using System;
using System.Collections.Generic;
using System.Text;

namespace LW_4
{
    public abstract class WhatICan
    {
        public abstract void ICan();
        public virtual bool IsEdible() { return false; }
    }
}
