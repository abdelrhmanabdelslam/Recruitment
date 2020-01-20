using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.DTOS.CompanyCoverImageDTOS
{
   public  class CompanyCoverImageReturnDTO
    {
        public int  CompanyCoverImageId { get; set; }
        public string CompanyCoverImageName { get; set; }
        public int CompanyInformationId { get; set; }
        public string ComapnyCoverImageURL { get; set; }
        public bool IsMainCover { get; set; }
    }
}


