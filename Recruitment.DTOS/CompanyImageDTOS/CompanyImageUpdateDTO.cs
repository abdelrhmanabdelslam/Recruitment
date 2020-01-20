using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.DTOS.CompanyImageDTOS
{
   public  class CompanyImageUpdateDTO
    {
        public int CompanyImageId { get; set; }
        public int CompanyInformationId { get; set; }
        public string CompanyImgeURL { get; set; }
        public bool IsMainPhoto { get; set; }
    }
}


