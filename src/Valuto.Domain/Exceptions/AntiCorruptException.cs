using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.Exceptions
{
    public class AntiCorruptException : Exception
    {
        public AntiCorruptException() : base() { }
        public AntiCorruptException(string message) : base(message) { }
        public AntiCorruptException(string message, Exception innerException) : base(message, innerException) { }
    }
}
