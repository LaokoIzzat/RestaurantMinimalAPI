namespace RestaurantMinimalAPI;

public static class Apis
{
    public static void ConfigureApi(this WebApplication app)
    {
        // API endpoint mappings
        app.MapGet("/Restaurants", GetRestaurants);
        app.MapGet("/Restaurants/{id}", GetRestaurant);
        app.MapPost("/Restaurants", InsertRestaurant);
        app.MapPut("/Restaurants", UpdateRestaurant);
        app.MapDelete("/Restaurants", DeleteRestaurant);
    }

    private static async Task<IResult> GetRestaurants(IRestaurantData data)
    {
        try
        {
            return Results.Ok(await data.GetRestaurants());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetRestaurant(IRestaurantData data, int id)
    {
        try
        {
            var results = await data.GetRestaurant(id);
            if (results == null) return Results.NotFound();
            return Results.Ok(results);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertRestaurant(IRestaurantData data, RestaurantModel restaurant)
    {
        try
        {
            await data.InsertRestaurant(restaurant);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateRestaurant(IRestaurantData data, RestaurantModel restaurant)
    {
        try
        {
            await data.UpdateRestaurant(restaurant);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteRestaurant(IRestaurantData data, int id)
    {
        try
        {
            await data.DeleteRestaurant(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
