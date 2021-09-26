using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Entities.Exceptions
{
    public class ContextException : Exception
    {
        public ContextException() : base() { }
        public ContextException(string message) : base(message) { }
        public ContextException(string message, Exception inner) : base(message, inner) { }
    }
}
