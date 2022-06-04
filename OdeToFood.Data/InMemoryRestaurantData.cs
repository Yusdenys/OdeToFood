using OdeToFood.Core;
using System.Linq;
using OdeToFood.Core;
using System.Collections.Generic;

namespace OdeToFood.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Scott's Pizza",  Location = "Illinois", Cuisine = CuisineType.None},
                new Restaurant { Id = 1, Name = "Cinnamon Club",  Location = "Maryland", Cuisine = CuisineType.Mexican},
                new Restaurant { Id = 1, Name = "Perez's Club",  Location = "Florida", Cuisine = CuisineType.Indian}
            };

        }
        public IEnumerable<Restaurant> GetRestaurantsByName(string name)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }

        IEnumerable<Restaurant> IRestaurantData.GetRestaurantsByName(string name)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }     
    }
}
