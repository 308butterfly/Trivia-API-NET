var builder = WebApplication.CreateBuilder(args);
var settings = "appSettings.json";

// Load configuration
builder.Configuration.AddJsonFile(settings);
// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Singleton, Scoped, Transient
/*
 Singleton - Service for lifetime of the application
 Scoped - created once per client request i.e. sql connection
 Transient - use it and throw it away like an httpClient
 */

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(options => options
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
