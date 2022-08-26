using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Helpers.Exceptions
{
    internal class NotFoundException : Exception
    {
        public NotFoundException(string message):base(message)
        {

        }
    }
}
