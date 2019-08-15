using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetById(int id);
        Restaurant Update(Restaurant updatedRestaurant);
        Restaurant Add(Restaurant newRestaurant);
        int Commit();
    }
    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id=1,Name="Scott's Pizza",Location="Maryland",Cuisine=CuisineType.Italian},
                new Restaurant{Id=2,Name="Cinnamon Club",Location="London",Cuisine=CuisineType.Indian },
                new Restaurant{Id=3,Name="La Costa",Location="California",Cuisine=CuisineType.Mexican}
            };
        }

        public Restaurant Add(Restaurant newRestaurant)
        {
            restaurants.Add(newRestaurant);
            newRestaurant.Id = restaurants.Max(r => r.Id) + 1;
            return newRestaurant;
        }

        public int Commit()
        {
            return 0;
        }

        public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var restuarant = restaurants.SingleOrDefault(r => r.Id == updatedRestaurant.Id);
            if(restuarant != null)
            {
                restuarant.Name = updatedRestaurant.Name;
                restuarant.Location = updatedRestaurant.Location;
                restuarant.Cuisine = updatedRestaurant.Cuisine;
            }
            return restuarant;
        }
    }
}
