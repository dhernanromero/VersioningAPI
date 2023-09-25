using Web_Api_Versioning.Api.Models.Domain;

namespace Web_Api_Versioning.Api
{
    public static class CountriesData
    {
        public static List<Country> Get()
        {
            var countries = new[]
            {
                new {Id = 1 , Name = "Argentina" },
                new {Id = 2 , Name = "United States" },
                new {Id = 3 , Name = "Japan" },
                new {Id = 4 , Name = "Mexico" },
                new {Id = 5 , Name = "China" }
            };

            return countries.Select( c => new Country { Id = c.Id, Name = c.Name }).ToList();
        }
    }
}
