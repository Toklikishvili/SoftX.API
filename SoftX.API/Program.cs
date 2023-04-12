using Microsoft.EntityFrameworkCore;
using SoftX.API.AutoMaper;
using SoftX.Facade.Repository;
using SoftX.Facade.Service;
using SoftX.Repository;
using SoftX.Repository.Date;
using SoftX.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SoftXDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
