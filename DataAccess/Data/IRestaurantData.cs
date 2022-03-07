using DataAccess.Models;

namespace DataAccess.Data;

public interface IRestaurantData
{
    Task DeleteRestaurant(int id);
    Task<RestaurantModel> GetRestaurant(int id);
    Task<IEnumerable<RestaurantModel>> GetRestaurants();
    Task InsertRestaurant(RestaurantModel restaurant);
    Task UpdateRestaurant(RestaurantModel restaurant);
}