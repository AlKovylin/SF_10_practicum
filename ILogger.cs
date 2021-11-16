using System;
using System.Collections.Generic;
using System.Text;

namespace SF_10_practicum
{
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
}
