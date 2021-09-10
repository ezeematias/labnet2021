using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Library
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException() : base() { }

        public InvalidInputException(string message) : base(message) { }

        public InvalidInputException(string message, Exception inner) : base(message, inner) { }
    }
}
