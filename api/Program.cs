using System.Security.Cryptography.Xml;
using api.data;
using api.interfaces;
using api.Migrations;
using api.models;
using api.repositories;
using api.services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers().AddNewtonsoftJson(options =>{
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});

builder.Services.AddDbContext<ApplicationDbContext>(options =>{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddIdentity<User, IdentityRole>(options =>{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase =true;
    options.Password.RequireUppercase =true;
    options.Password.RequireNonAlphanumeric =true;
    options.Password.RequiredLength = 12;

}).AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddAuthentication(options => {
    options.DefaultAuthenticateScheme=
    options.DefaultChallengeScheme =
    options.DefaultForbidScheme =
    options.DefaultScheme =
    options.DefaultSignInScheme =
    options.DefaultSignOutScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>{
    options.TokenValidationParameters = new TokenValidationParameters{
        ValidateIssuer = true,
        ValidIssuer = builder.Configuration["JWT:Issuer"],
        ValidateAudience = true,
        ValidAudience = builder.Configuration["JWT:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(
            System.Text.Encoding.UTF8.GetBytes(builder.Configuration["JWT:SigninKey"])
        )
    };
});

builder.Services.AddScoped<IUserRepository,UserRepository>();
builder.Services.AddScoped<ICollegeRepository,CollegeRepository>();
builder.Services.AddScoped<ISemesterRepository,SemesterRepository>();
builder.Services.AddScoped<ISubjectRepository,SubjectRepository>();
builder.Services.AddScoped<ITokenServices, TokenService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.UseAuthentication();
app.UseAuthorization();

app.Run();

