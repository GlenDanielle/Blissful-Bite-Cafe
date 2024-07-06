using BackEnd.Data;
using BackEnd.Endpoint;
//import to


var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("RestoDb");
//sa appsettings.json nakalagay tong connection string
//it acts like a .env 
builder.Services.AddSqlite<RestoContext>(connString);

//builder.Services.AddScoped<RestoContext>();

var app = builder.Build();

//route
app.MapGet("/", () => 
    "Der Vogel kämpft sich aus dem Ei"
);

app.MapOrderEndpoints();

app.MigrateDb();

app.Run();
