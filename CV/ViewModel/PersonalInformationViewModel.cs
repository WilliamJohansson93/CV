using CV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CV.ViewModel
{
    public class PersonalInformationViewModel : EmailSuccess
    {
        public List<Education> Education { get; set; }
        public List<WorkExperience> WorkExperience { get; set; }
    }
}