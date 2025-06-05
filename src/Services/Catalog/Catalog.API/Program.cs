var builder = WebApplication.CreateBuilder(args);

// Add services to the container if needed, e.g.:
// builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.


app.Run();
