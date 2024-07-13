using BackEnd.Data;
using BackEnd.Endpoint;
using DotNetEnv;
//import to


var builder = WebApplication.CreateBuilder(args);


//Loads Env files
Env.Load();

//FrontEnd url to use in cors env makes it more scalable and maintanable
var FrontEndUrl = Environment.GetEnvironmentVariable("FrontEndUrl");

var connString = builder.Configuration.GetConnectionString("RestoDb");

//sa appsettings.json nakalagay tong connection string
//it acts like a .env 
builder.Services.AddSqlite<RestoContext>(connString);


//cors config 
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigins",
        builder =>
        {
            builder.WithOrigins(FrontEndUrl)
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

var app = builder.Build();

// Use CORS middleware
app.UseCors("AllowSpecificOrigins");

//route
app.MapGet("/", () => 
    "Der Vogel kämpft sich aus dem Ei"
);

app.MapOrderEndpoints();

await app.MigrateDbAsync();

app.Run();
