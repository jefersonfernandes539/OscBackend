using Microsoft.AspNetCore.Mvc;
using OscBackend.Models;
using OscBackend.Services.Interfaces;

namespace OscBackend.Controllers
{
    [ApiController]
    [Route("api/onglocation")]
    public class OngLocationController(IOngLocationService service) : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<OngLocation>>> GetAll()
        {
            var ongs = await service.GetAllAsync();
            return Ok(ongs);
        }
    }
}
