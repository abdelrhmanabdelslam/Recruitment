using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.DTOS.PostDTOS
{
   public  class PostUpdateDTO
    {
        public long PostId { get; set; }
        public byte PostTypeId { get; set; }
        public int PostLocationId { get; set; }
        public string Area { get; set; }
        public byte CareerLevelId { get; set; }
        public string YearsOfExperience { get; set; }
        public decimal SalaryFrom { get; set; }
        public decimal SalaryTo { get; set; }
        public bool IsHideSalary { get; set; }
        public string AddationalSalary { get; set; }
        public byte NumberOfVacancies { get; set; }
        public string PostDescription { get; set; }
        public bool? IsClosed { get; set; }
    }
}


