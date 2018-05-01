using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CV.Models
{
    public class EmailSuccess
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Profession { get; set; }
        public string CompanyName { get; set; }
        public string cAddress { get; set; }
        public string Message { get; set; }
        public bool EmailSentSuccess { get; set; }
    }
}