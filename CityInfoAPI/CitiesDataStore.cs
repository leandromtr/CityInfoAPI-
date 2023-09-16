using CityInfoAPI.Models;
using System.Xml.Linq;

namespace CityInfoAPI
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "São Paulo",
                    Description = "Poluted and dangeour city",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto(){
                            Id = 1,
                            Name = "Masp",
                            Description = "Modern Art Museum"},
                        new PointOfInterestDto(){
                            Id = 2,
                            Name = "Arena Corinthians",
                            Description = "House of Corinthians"},
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Paris",
                    Description = "Dirty and dangeour city",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto(){
                            Id = 3,
                            Name = "Effiel Tower",
                            Description = "France monument"},
                        new PointOfInterestDto(){
                            Id = 4,
                            Name = "Champs Elysee",
                            Description = "Fancy street"},
                    }
                },
                 new CityDto()
                 {
                    Id = 3,
                    Name = "Porto",
                    Description = "Old city",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto(){
                            Id = 5,
                            Name = "Ribeira",
                            Description = "The most beaultiful place of Porto"},
                        new PointOfInterestDto(){
                            Id = 6,
                            Name = "Torre dos Clerigos",
                            Description = "Big Tower"},
                    }
                }
            };
        }
    }
}
