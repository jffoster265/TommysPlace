using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tommys_Place.Models
{
    public class Customer
    {
        public int customerId { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String address { get; set; }
        public String city { get; set; }
        public String state { get; set; }
        public String zipCode { get; set; }
        public String phone { get; set; }
        public String email { get; set; }
        public String userName { get; set; }
        public String password { get; set; }
        public bool customerStatus { get; set; }
        public DateTime dateAdded { get; set; }
        public DateTime dateModified { get; set; }
    }
}