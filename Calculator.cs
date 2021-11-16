using System;
using System.Collections.Generic;
using System.Text;

namespace SF_10_practicum
{
    class Calculator : ISum
    {
        public float Sum(float x, float y)
        {
            return x + y;
        }
    }
}
