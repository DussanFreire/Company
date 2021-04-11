using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    class Client : IClient
    {
        public string Gender { get ; set ; }
        public long Id { get ; set ; }
        public string Name { get ; set ; }
        public string Email { get  ; set  ; }
        public int TelephonNumber { get  ; set  ; }

        public void PresentYourSelf()
        {
            Console.WriteLine($"Helo, I'm {Name}");
        }
    }
}
