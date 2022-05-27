using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;


namespace CityInfo.API.Controllers
{
    [ApiController] //automatically returning requests, auto routings
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        private readonly CitiesDataStore _citiesDataStore;

        public CitiesController(CitiesDataStore citiesDataStore)
        {
            _citiesDataStore = citiesDataStore;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CityDto>> GetCities()
        {
            return Ok(_citiesDataStore.Cities); 
                        
        }

        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id)
        {
            //find city
            var cityToReturn = _citiesDataStore.Cities.FirstOrDefault(p => p.Id == id);

            if (cityToReturn == null)
            {
                return NotFound();
            }
            return Ok(cityToReturn);
        }
    }
}
