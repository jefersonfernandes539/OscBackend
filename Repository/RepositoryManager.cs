using Microsoft.EntityFrameworkCore.Storage;
using OscBackend.Repository.Interfaces;

namespace OscBackend.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;

        private readonly Lazy<IOngLocationRepository> _ongLocationRepository;
        public RepositoryManager(RepositoryContext context)
        {
            _context = context;
            _ongLocationRepository = new Lazy<IOngLocationRepository>(() => new OngLocationRepository(context));
        }

        public IDbContextTransaction BeginTransaction() => _context.Database.BeginTransaction();
        public IOngLocationRepository OngLocationRepository => _ongLocationRepository.Value;

        public async Task SaveAsync() => await _context.SaveChangesAsync();
    }
}
