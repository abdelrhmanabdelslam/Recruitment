using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.DTOS.CompanyInformationDTOS
{
   public  class CompanyInformationAddDTO
    {
        public byte CompanyTypeId { get; set; }
        public int EmployerId { get; set; }
        public string CompanyWebsite { get; set; }
        public string CompanyName { get; set; }
        public string Fax { get; set; }
        public string CompanyPhone { get; set; }
        public byte  CompanySizeId { get; set; }
        public int YearFounded { get; set; }
        public string CompanyProfile { get; set; }
        public string  Specialties { get; set; }
        public bool  IsStartupCompany { get; set; }
        public bool IsMultinational { get; set; }
        public string Logo { get; set; }
    }
}


