using FatecRentAPI.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using System.Collections.Generic;

namespace FatecRentAPI.Tests
{
    public class VehicleControllerTests
    {
        VehicleController subject;
        Mock<IVehicleRepository> repositorio;
        public VehicleControllerTests()
        {
           repositorio = new Mock<IVehicleRepository>();
            
           subject = new VehicleController(Mock.Of<ILogger<VehicleController>>(),
                repositorio.Object);
        }

        [Fact]
        public async Task GET_retorna_uma_lista_de_veiculos()
        {
            var vehicles = await subject.Get();

            Assert.IsAssignableFrom<IEnumerable<Vehicle>>(vehicles);
        }
        
        [Fact]
        public async Task GET_retorna_a_lista_retornada_do_repositorio()
        {
            var esperado = new List<Vehicle>();
            repositorio.Setup(r => r.GetAll()).ReturnsAsync(esperado);

            var vehicles = await subject.Get();

            Assert.Same(esperado,vehicles );
        }
    }
}