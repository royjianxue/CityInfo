using CityInfo.API.Models;


namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public CitiesDataStore()
        {
            //init dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park",
                    PointOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited urban park in the unite states."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Midtown Manhattan"
                        }                   
                    }

                },
                new CityDto()
                {
                    Id = 2, 
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never really finished",
                    PointOfInterest= new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "I don't know",
                            Description = "Yeah yeah yeah yeah yah Laught all you want"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Antwerp Central Station",
                            Description = "The finest example of railway architechture in Belgium"
                        }
                    }
                    


                },
                new CityDto(){ 
                
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with that Big Tower",
                    PointOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id= 5,
                            Name = "Eiffel Tower",
                            Description = "A wrought iron lattice tower on the CHamp de Mars, name after"                               
                        },

                        new PointOfInterestDto()
                        {
                            Id= 6,
                            Name = "The Louvre",
                            Description = "The world's largest museum"
                        }
                    }
                }             
            };
        }

    }
}
