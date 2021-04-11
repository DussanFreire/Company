using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    interface IClient : IPerson
    {
        public string Email { get; set; }
        public int TelephonNumber { get; set; }
    }
}
