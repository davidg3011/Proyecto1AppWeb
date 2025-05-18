using Microsoft.AspNetCore.SignalR;
using ShoppingApi_Jueves_2025I.DAL.Entities;

namespace ShoppingApi_Jueves_2025I.Domain.Interfaces
{
    public interface ICountryService
    {
        Task<IEnumerable<Country>> GetCountriesAsync(); //una de las tantas firmas de un metodo

        Task<Country> CreateCountryAsync(Country country);

        Task<Country> GetCountryByIdAsync(Guid id);

        Task<Country> EditCountryAsync(Country country);

        Task<Country> DeleteCountryAsync(Guid id);
    }
}
