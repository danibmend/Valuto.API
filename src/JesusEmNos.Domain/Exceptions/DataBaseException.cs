using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.Exceptions
{
    public class DataBaseException : Exception
    {
        public DataBaseException() : base() { }
        public DataBaseException(string message) : base(message) { }
        public DataBaseException(string message, Exception innerException) : base(message, innerException) { }
    }
}
