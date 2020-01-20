using Recruitment.DTOS.CountryDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface ICountryMapping
    {
        List<CountryReturnDTO> MappingCountryToCountryReturnDTO(List<Country> CountryList);
        Country MappingCountryAddDTOToCountry(CountryAddDTO CountryAddDTO);
        Country MappingCountryupdateDTOToCountry(Country Country,CountryUpdateDTO CountryUpdateDTO);
        CountryReturnDTO MappingCountryToCountryReturnDTO(Country Country);

    }
}




