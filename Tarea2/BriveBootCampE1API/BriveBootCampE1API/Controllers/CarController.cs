using BriveBootCampE1API.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BriveBootCampE1API.Controllers
{
    [EnableCors("Bootcamp")]
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        public List<Car> Cars = new List<Car>();
        public CarController()
        {
            for (int i = 1; i <= 10; i++)
            {
                Cars.Add(new Car
                {
                    Id = i,
                    Name = $"Jetta {i + 1}",
                    Model = $"Deportivo",
                    Company = $"volkswagen",
                    Age = 2000 + i,
                    CreateDate = DateTime.UtcNow
                });
            }
        }
        //APIBase/Controlador/Endpoint
        [HttpGet]
        [Route("all")]
        public ActionResult<List<Car>> GetAllCars()
        {
            return StatusCode(StatusCodes.Status200OK, Cars);
        }
        [HttpGet]
        [Route("id")]
        public ActionResult<Car> GetCarById(int id)
        {
            return StatusCode(StatusCodes.Status200OK, Cars.Where(Car => Car.Id == id).FirstOrDefault());
        }
        [HttpPost]
        //[Route("SavePerson")]
        public ActionResult<Car> SaveCar([FromBody] Car car)
        {
            return StatusCode(StatusCodes.Status200OK, car);
        }
        [HttpPut]
        public ActionResult<Car> EditedCar([FromBody] Car car)
        {
            Car editedCar = Cars.Where(x => x.Id == car.Id).FirstOrDefault();
            if (editedCar == null)
                return StatusCode(StatusCodes.Status400BadRequest, editedCar);
            car.Name = "Rio";
            car.Model = "Basico";
            car.Company = "Kia";
            car.Age = 2020;
            car.CreateDate = editedCar.CreateDate;

            return StatusCode(StatusCodes.Status200OK, car);
        }
        [HttpDelete]
        public ActionResult<List<Car>> DeleteCar([FromBody] int id)
        {
            return StatusCode(StatusCodes.Status200OK, Cars.Where(Car => Car.Id != id));
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<bool> Deleted2Car(int id)
        {
            return StatusCode(StatusCodes.Status200OK, true);
        }
    }
}
