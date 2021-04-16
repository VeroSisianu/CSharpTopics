using System;
using System.Collections.Generic;
using System.Text;

namespace Lectia23_1
{
    class Factory
    {
        string name;
        int postcode;
        string street;
        public Factory(string name, int postcode, string street)
        {
            this.name = name;
            this.postcode = postcode;
            this.street = street;
        }
        public class Address
        {
            public string GetAddress(Factory factory)
            {

                return $"Factory {factory.name} is on {factory.street} {factory.postcode}";
            }
        }
    }
}
