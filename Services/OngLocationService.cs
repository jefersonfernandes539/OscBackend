using OscBackend.DataTransferObjects;
using OscBackend.Repository.Interfaces;
using OscBackend.Services.Interfaces;

namespace OscBackend.Services
{
    public class OngLocationService(IRepositoryManager repository) : IOngLocationService
    {
        public async Task<List<OngLocationDto>> GetAllAsync()
        {
            var entities = await repository.OngLocationRepository.GetAllAsync();

            var dtos = entities.Select(x => new OngLocationDto
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Latitude = x.Latitude,
                Longitude = x.Longitude,
                Address = x.Address,
                Phone = x.Phone,
                Email = x.Email,
                Type = x.Type,
                Services = x.Services.ToList()
            }).ToList();

            return dtos;
        }

    }
}
