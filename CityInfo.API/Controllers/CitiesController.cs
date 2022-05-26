using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;


namespace CityInfo.API.Controllers
{
    [ApiController] //automatically returning requests, auto routings
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<CityDto>> GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities); 
                        
        }

        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id)
        {
            //find city
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(p => p.Id == id);

            if (cityToReturn == null)
            {
                return NotFound();
            }
            return Ok(cityToReturn);
        }
    }
}
