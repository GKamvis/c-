using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Webapi_student_questionnaire.Controllers;
using Webapi_student_questionnaire.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//auth
var issuer = builder.Configuration["JwtConfig:Issuer"];
var audiences = builder.Configuration["JwtConfig:Audiences"];
var signingKey = builder.Configuration["JwtConfig:SigningKey"];

// Əgər 'signingKey' null olarsa, xəta mesajı ver.
if (string.IsNullOrEmpty(signingKey))
{
    throw new InvalidOperationException("JwtConfig:SigningKey is missing in the configuration.");
}

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        // Qalan konfiqurasiya parametrləri...
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(signingKey))
    };
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.MapStudentEndpoints();

app.Run();
