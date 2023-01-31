using API.Data;
using API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// add JsonContactService as a scoped service
builder.Services.AddScoped<JsonContactService>();
// add JsonFileRepository as a scoped service
builder.Services.AddScoped<JsonFileRepository>();

// add AutoMapper as a scoped service
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// add a CORS policy to accept http requests from http://localhost:3000
app.UseCors(options => options.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();

app.Run();
