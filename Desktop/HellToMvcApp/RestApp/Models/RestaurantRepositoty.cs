using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestApp.Models
{
    public class RestaurantRepositoty
    {
        static List<Restaurant> list = new List<Restaurant>()
        {
            new Restaurant {Id=1, Title="Dominos", Rating=5, City="Mumbai" },
            new Restaurant {Id=3, Title="Hldiram", Rating=5, City="Lucknow" },
            new Restaurant {Id=4, Title="PindBaluchi", Rating=5, City="Noida" }
        };
        public List<Restaurant> GetAllRestaurant()
        {
            return list;
        }

        public Restaurant GetRestaurantById(int id)
        {
            return list.Find(x => x.Id == id);
        }
        public void AddRestaurant(Restaurant rest)
        {
            list.Add(rest);
        }
        public void EditRestaurant(int id ,Restaurant rest)
        {
            var res = list.Find(x => x.Id == id);
            if(res != null)
            {
                res.Title = rest.Title;
                res.Rating = rest.Rating;
                res.City = rest.City;
            }
        }
    }
}