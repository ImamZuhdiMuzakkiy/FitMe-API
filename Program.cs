using FitMe.API.Data;
using FitMe.API.Repositories.Data;
using FitMe.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//add dbcontext 
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<FitMeDbContext>(options =>
    options.UseSqlServer(connectionString)
);

//Register Repository Service
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IProgramEnrollRepository, ProgramEnrollRepository>();
builder.Services.AddScoped<IWorkoutProgramRepository, WorkoutProgramRepository>();
builder.Services.AddScoped<IWorkoutSessionRepository, WorkoutSessionRepository>();




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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
