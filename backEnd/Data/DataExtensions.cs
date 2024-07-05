using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data;

public static class DataExtensions
{
    public static void MigrateDb(this WebApplication app){
        using var scope = app.Services.CreateScope();
        //used to request an instances of service
        var dbContext = scope.ServiceProvider.GetRequiredService<RestoContext>();
        dbContext.Database.Migrate();
    }
}
