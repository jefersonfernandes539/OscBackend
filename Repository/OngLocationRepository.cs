using Eecomerce.Repository;
using Microsoft.EntityFrameworkCore;
using OscBackend.Models;
using OscBackend.Repository.Interfaces;

namespace OscBackend.Repository
{
    public class OngLocationRepository : RepositoryBase<OngLocation>, IOngLocationRepository
    {
        public OngLocationRepository(RepositoryContext context) : base(context) { }

        public async Task<List<OngLocation>> GetAllAsync()
        {
            return await FindAll(trackChanges: false).ToListAsync();
        }

        public void Create(OngLocation ongLocation) => Add(ongLocation);

    }
}
