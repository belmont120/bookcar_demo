using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookcar_demo.Core;
using Bookcar_demo.Dto;
using Bookcar_demo.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Bookcar_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private IBorrowRecordRepostitory _borrowRecordRepostitory;
        private IUserRepository _userRepository;
        private ICarRepository _carRepository;
        private IConfiguration _configuration;

        public BookingsController(IBorrowRecordRepostitory borrowRecordRepostitory, IUserRepository userRepository, ICarRepository carRepository, IConfiguration configuration)
        {
            _borrowRecordRepostitory = borrowRecordRepostitory;
            _userRepository = userRepository;
            _carRepository = carRepository;
            _configuration = configuration;
        }

        [HttpPost]
        public ActionResult Post([FromBody] BorrowRecordDto borrowRecordDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (!_carRepository.CheckCarExists(borrowRecordDto.CarRego) || !_userRepository.CheckUserExists(borrowRecordDto.UserId))
            {
                return NotFound();
            }

            int borrowExpInHours = Convert.ToInt32(_configuration["Settings:BorrowExpInHours"]);

           
            if (_borrowRecordRepostitory.CheckCarAvailability(borrowRecordDto.CarRego, borrowExpInHours))
            {
                return BadRequest("The car is not available.");
            }

            var newRecord = new BorrowRecord
            {
                CarRego = borrowRecordDto.CarRego,
                UserId = borrowRecordDto.UserId,
                CreateDate = DateTime.Now,
            };

            try
            {
                _borrowRecordRepostitory.Add(newRecord);
                _borrowRecordRepostitory.AppDbContext.SaveChanges();
            }
            catch(Exception ex)
            {
                var errorMessage = ex.Message;
                // TODO: Log Error
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            return CreatedAtRoute(Request.Path.Value + newRecord.BorrowRecordId, newRecord);

        }


    }
}