using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.DTOS.CompanyImageDTOS
{
   public  class CompanyImageAddDTO
    {
        public int  CompanyInformationId { get; set; }
        public string CompanyImgeURL { get; set; }
        public bool IsMainPhoto { get; set; }
    }
}


