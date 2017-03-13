using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment7.Models
{
    public class PersonLite
    {
        public int PersonKey { set; get; }

        public string LastName { set; get; }

        public string FirstName { set; get; }

        public string Email { set; get; }

        public string Apartment { set; get; }

        public string Street { set; get; }

        public string City { set; get; }

        public string State { set; get; }

        public string Zipcode { set; get; }

        public string HomePhone { set; get; }

        public string WorkPhone { set; get; }

        public string Password { set; get; }


    }
}