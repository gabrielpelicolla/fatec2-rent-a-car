using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FatecRentAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly ILogger<VehicleController> logger;
        private readonly IVehicleRepository vehicleRepository;

        public VehicleController(ILogger<VehicleController> logger, IVehicleRepository repository)
        {
            this.logger = logger;
            this.vehicleRepository = repository;
        }

        [HttpGet]

        public async Task<IEnumerable<Vehicle>> Get()
        {
            logger.LogInformation("Get execultado com sucesso");
            return await vehicleRepository.GetAll();
        }
    }
}