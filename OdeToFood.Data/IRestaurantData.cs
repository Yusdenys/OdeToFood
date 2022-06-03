using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

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
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants 
                   orderby r.Name
                   select r;  
        }
    }
}
