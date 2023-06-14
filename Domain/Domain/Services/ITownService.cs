namespace Domain.Services;

using Domain.Models;

public interface ITownService
{
    Task<IEnumerable<TownModel>> GetTownModels();

    Task<TownModel> GetTownModelById(int id);

    Task<int> AddTown(TownModel townModel);

    Task<int> UpdateTown(TownModel townModel);

    Task<bool> DeleteTown(int id);
}
