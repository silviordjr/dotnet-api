using cars.Model;
using cars.Repository;
using Microsoft.AspNetCore.Mvc;

namespace cars.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly ICarsRepository _carsRepository;
        public CarsController (ICarsRepository carsRepository)
        {
            _carsRepository = carsRepository;
        }

        [HttpGet]
        [Produces(typeof(Cars))]
        public IActionResult Get()
        {
            var cars = _carsRepository.GetAll();

            if (cars.Count() == 0)
                return NoContent();

            return Ok(cars); 
        }
    }
}