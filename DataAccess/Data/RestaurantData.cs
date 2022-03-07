using DataAccess.DBAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;
public class RestaurantData : IRestaurantData
{
    private readonly ISqlDataAccess _db;

    public RestaurantData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<RestaurantModel>> GetRestaurants() =>
        _db.LoadData<RestaurantModel, dynamic>("dbo.spRestaurant_GetAll", new { });

    public async Task<RestaurantModel> GetRestaurant(int id) =>
        (await _db.LoadData<RestaurantModel, dynamic>("dbo.spRestaurant_Get", new { Id = id })).FirstOrDefault();


    public Task InsertRestaurant(RestaurantModel restaurant) =>
        _db.SaveData("spRestaurant_Insert", new { restaurant.Name, restaurant.Location });

    public Task UpdateRestaurant(RestaurantModel restaurant) =>
        _db.SaveData("spRestaurant_Update", restaurant);

    public Task DeleteRestaurant(int id) =>
        _db.SaveData("spRestaurant_Delete", new { Id = id });
}
