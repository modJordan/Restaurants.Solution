// Name, City, RestaurantId Cuisine TheCuisine

namespace BestRestaurants.Models;

  public class Restaurant
  {
    public string Name { get; set; }
    public string City { get; set; }
    public int RestaurantId { get; set; }
    public Cuisine Cuisine {get; set;}

  }

  public enum Cuisine
{
    INDIAN = 1,
    MEDITERRANEAN = 2,
    MEXICAN = 3,
    ITALIAN = 4,
    THAI = 5,
    SUSHI = 6,
    ICECREAM = 7,
    BURGERS = 8
}



