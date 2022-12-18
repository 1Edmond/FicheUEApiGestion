using FicheUEApiGestion.Customs;
using FicheUEApiGestion.MyContext;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddDbContext<FicheUEApiGestionContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FicheUEApiGestionContext") ?? throw new InvalidOperationException("Connection string FicheUEApiGestionContext not found"))
);

// Ajout de l'authentification
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(bearer =>
{
    bearer.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = MyConstants.SIGN_KEY,
        ValidIssuer = MyConstants.ISSUER,
        ValidAudience = MyConstants.AUDIANCE,
        ValidateLifetime = true
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

app.UseAuthorization();

app.MapControllers();

app.Run();
