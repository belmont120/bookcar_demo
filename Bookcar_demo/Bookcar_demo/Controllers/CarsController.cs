using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookcar_demo.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Bookcar_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private IConfiguration _configuration;
        private ICarRepository _carRepository;
        private IBorrowRecordRepostitory _borrowRecordRepostitory;

        public CarsController(IConfiguration configuration, ICarRepository carRepository, IBorrowRecordRepostitory borrowRecordRepostitory)
        {
            _configuration = configuration;
            _carRepository = carRepository;
            _borrowRecordRepostitory = borrowRecordRepostitory;
        }

        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            var cars = _carRepository.GetAll();

            return Ok(cars);
        }

        [HttpGet("available")]
        public ActionResult<string> GetAvailableCars()
        {
            int borrowExpInHours = Convert.ToInt32(_configuration["Settings:BorrowExpInHours"]);

            var availableCars = _carRepository.GetAvailableCars(borrowExpInHours);

            return Ok(availableCars);
        }


    }
}
