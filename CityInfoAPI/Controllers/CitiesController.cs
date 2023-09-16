using CityInfoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<CityDto>> GetCities()
        {
            return Ok((CitiesDataStore.Current.Cities));
            //var temp = new JsonResult(CitiesDataStore.Current.Cities);
            //temp.StatusCode = 200;
            //return new JsonResult(CitiesDataStore.Current.Cities);

        }

        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id)
        {
            // Find city
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);

            if (cityToReturn == null)
            {
                return NotFound(); 
            }
            return Ok(cityToReturn);
        }
    }
}
