using Recruitment.DTOS.EmployerDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface IEmployerMapping
    {
        List<EmployerReturnDTO> MappingEmployerToEmployerReturnDTO(List<Employer> EmployerList);
        Employer MappingEmployerAddDTOToEmployer(EmployerAddDTO EmployerAddDTO);
        Employer MappingEmployerupdateDTOToEmployer(Employer Employer,EmployerUpdateDTO EmployerUpdateDTO);
        EmployerReturnDTO MappingEmployerToEmployerReturnDTO(Employer Employer);

    }
}




