using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KerstKaartenGenerator.Models
{
    public class Contact
    {
        public int ContactID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName 
        { 
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }

        [EmailAddress]
        public string Email { get; set; }
    }
}
