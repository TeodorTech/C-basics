using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programe
{
    internal class ExceptionAge:Exception
    {
        public ExceptionAge(string? message) : base(message)
        {
        }

    }
}
