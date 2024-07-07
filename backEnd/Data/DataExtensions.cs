using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data;

public static class DataExtensions
{
    public static async Task MigrateDbAsync(this WebApplication app){ //i used task so i can use async instead of void that returns nothing
        using var scope = app.Services.CreateScope();
        //used to request an instances of service
        var dbContext = scope.ServiceProvider.GetRequiredService<RestoContext>();
        await dbContext.Database.MigrateAsync();
    }
}
