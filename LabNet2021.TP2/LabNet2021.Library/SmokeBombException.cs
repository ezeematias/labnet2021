using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Library
{
    public class SmokeBombException : Exception
    {
        public SmokeBombException() : base() { }

        public SmokeBombException(string message) : base(message) { }

        public SmokeBombException(string message, Exception inner) : base(message, inner) { }
    }
}
