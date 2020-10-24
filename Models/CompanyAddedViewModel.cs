using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Web.Models
{
    public class CompanyAddedViewModel: CompanyModel
    {
        public int NumberOfCharsInName { get; set; }

        public int NumberOfCharsInDescription { get; set; }

        public bool IsHidden { get; set; }
        
    }
}
