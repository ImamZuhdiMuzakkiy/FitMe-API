using System.Text;
using FitMe.API.Data;
using FitMe.API.Repositories;
using FitMe.API.Repositories.Data;
using FitMe.API.Repositories.Interfaces;
using FitMe.API.Services;
using FitMe.API.Services.Interfaces;
using FitMe.API.Utilities;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;

// using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Models;



// using Microsoft.OpenApi;

// using Microsoft.OpenApi;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Extensions;
using TokenHandler = FitMe.API.Utilities.TokenHandler;

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

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IWorkoutProgramService, WorkoutProgramService>();
builder.Services.AddScoped<IProgramEnrollService, ProgramEnrollService>();
builder.Services.AddScoped<IUserService, UserService>();
// builder.Services.AddScoped<ITokenHandler, TokenHandler>();

builder.Services.AddExceptionHandler<GlobalExceptionHandler>();



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme {
        Name = "Authorization",
        Description = "Enter the Bearer Authorization string as following: `Bearer Generated-JWT-Token`",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT"
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
             new OpenApiSecurityScheme {
                Name = "Bearer",
                In = ParameterLocation.Header,
                Reference = new OpenApiReference {
                    Id = "Bearer",
                    Type = ReferenceType.SecurityScheme
                }
            },
            new List<string>()
        }
    });
});

// builder.Services.AddFluentValidationAutoValidation().AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
// builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);
builder.Services.AddFluentValidationAutoValidation().AddValidatorsFromAssembly(typeof(Program).Assembly);

var smtpServer = builder.Configuration["EmailSettings:SMTPServer"];
var smtpPort = builder.Configuration["EmailSettings:SMTPPort"];
var smtpUsername = builder.Configuration["EmailSettings:SMTPUsername"];
var smtpPassword = builder.Configuration["EmailSettings:SMTPPassword"];
var smtpFromMail = builder.Configuration["EmailSettings:SMTPFrom"];
builder.Services.AddTransient<IEmailHandler, EmailHandler>(_ => new EmailHandler(
    smtpServer ?? "localhost",
    Convert.ToInt16(smtpPort),
    smtpUsername ?? "unknown",
    smtpPassword ?? "unknown",
    smtpFromMail ?? "unknown@mail.id"
));
builder.Services.AddScoped<IHashHandler, HashHandler>();

//Authentication Configuration
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x. DefaultChallengeScheme = JwtBearerDefaults. AuthenticationScheme;
    x. DefaultScheme = JwtBearerDefaults. AuthenticationScheme;
}).AddJwtBearer (x =>
{
    x. TokenValidationParameters = new TokenValidationParameters
    {
        ValidIssuer = builder. Configuration["Jwt:Issuer"],
        ValidAudience = builder. Configuration["Jwt:Audience" ],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ClockSkew = TimeSpan.Zero
    };
});

var jwtKey = builder.Configuration["Jwt:Key"] ?? "InvalidKey";
var jwtIssuer = builder.Configuration["Jwt:Issuer"] ?? "InvalidIssuer";
var jwtAudience = builder.Configuration["Jwt:Audience"] ?? "InvalidAudience";
var expireTime = Convert.ToInt16(builder.Configuration["Jwt:ExpireTime"] ?? "1");
builder.Services.AddScoped<ITokenHandler, TokenHandler>(_ => 
    new TokenHandler(jwtKey, jwtIssuer, jwtAudience, expireTime));

// CORS Configuration
// Program.cs
// builder
builder.Services.AddCors(cfg => cfg.AddDefaultPolicy(policy =>
{
    policy.AllowAnyOrigin();
    policy.AllowAnyHeader();
    policy.AllowAnyMethod();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler(_ => { });

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();

