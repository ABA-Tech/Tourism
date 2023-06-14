namespace Domain.Services;

using Domain.Models;

public interface IMuseumService
{
    Task<IEnumerable<MuseumModel>> GetMuseumModels();

    Task<MuseumModel> GetMuseumModelById(int id);

    Task<int> AddMuseum(MuseumModel model);

    Task<int> UpdateMuseum(MuseumModel model);

    Task<bool> DeleteMuseum(int id);
}
