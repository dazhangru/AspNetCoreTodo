using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class C : IA, IB, IC
    {
        public string SayHi(string name)
        {
            return "Hi," + name;
        }
    }
}
