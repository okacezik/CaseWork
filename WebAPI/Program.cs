using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;

using DataAccess.Concretes.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IPatientService, PatientManager>();
builder.Services.AddSingleton<IPatientDal, EfPatientDal>();

//bas

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("https://localhost:3000").AllowAnyHeader()
                                                  .AllowAnyMethod().AllowAnyOrigin();
                      });
});

//son


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(builder => builder.WithOrigins("http://localhost:3000").AllowAnyHeader().WithMethods("GET", "POST", "DELETE", "PUT"));

app.UseAuthorization();

app.MapControllers();

app.Run();
