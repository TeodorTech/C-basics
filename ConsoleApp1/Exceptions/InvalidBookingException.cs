﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programe.Exceptions
{
    public class InvalidBookingException:Exception
    {
        public InvalidBookingException(string? message) : base(message)
        {

        }
    }
}
