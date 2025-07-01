using Microsoft.EntityFrameworkCore.Storage;

namespace OscBackend.Repository.Interfaces
{
    public interface IRepositoryManager
    {
        IOngLocationRepository OngLocationRepository { get; }

        IDbContextTransaction BeginTransaction();

        Task SaveAsync();
    }
}
