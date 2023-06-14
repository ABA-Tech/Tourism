namespace Domain.Services;

using Domain.Models;

internal interface ICountryService
{
    Task<IEnumerable<CountryModel>> GetCountryModels();

    Task<CountryModel> GetCountryById(int id);

    Task<int> AddCountry(CountryModel country);

    Task<int> UpdateCountry(CountryModel country);

    Task<bool> DeleteCountry(int id);
}
