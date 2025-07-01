using OscBackend.DataTransferObjects;

namespace OscBackend.Services.Interfaces
{
    public interface IOngLocationService
    {
        Task<List<OngLocationDto>> GetAllAsync();
    }
}
