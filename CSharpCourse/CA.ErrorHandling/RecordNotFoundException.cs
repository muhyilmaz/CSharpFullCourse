using System;
using System.Collections.Generic;
using System.Text;

namespace CA.ErrorHandling
{
    public class RecordNotFoundException :Exception
    {
        public RecordNotFoundException(string message) : base(message)
        {

        }
    }
}
