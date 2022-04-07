using System;
using System.Collections.Generic;
using System.Text;

namespace Http.Models
{
    internal class Address
    {
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public Geo Geo { get; set; }

    }
}
