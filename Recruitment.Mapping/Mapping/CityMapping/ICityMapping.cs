using Recruitment.DTOS.CityDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface ICityMapping
    {
        List<CityReturnDTO> MappingCityToCityReturnDTO(List<City> CityList);
        City MappingCityAddDTOToCity(CityAddDTO CityAddDTO);
        City MappingCityupdateDTOToCity(City City,CityUpdateDTO CityUpdateDTO);
        CityReturnDTO MappingCityToCityReturnDTO(City City);

    }
}




