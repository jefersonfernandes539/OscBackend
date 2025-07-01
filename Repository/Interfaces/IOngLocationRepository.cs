using OscBackend.Models;

namespace OscBackend.Repository.Interfaces
{
    public interface IOngLocationRepository
    {
        void Create(OngLocation ongLocation);
        Task<List<OngLocation>> GetAllAsync();
    }
}
