using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Core.ViewModels.Employment
{
    public class EmploymentViewModel
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public string Employer { get; set; }
        public string EmployerLogo { get; set; }
        public string EmployerUrl { get; set; }

    }
}
