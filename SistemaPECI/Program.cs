﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SistemaPECI.Client;
using SistemaPECI.Client.Interfaces;
using SistemaPECI.Client.Seguridad;
using SistemaPECI.Client.Servicios;
using SistemaPECI.Components;
using SistemaPECI.Data.Context;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Leer configuración JWT
var jwtKey = builder.Configuration["Jwt:Key"] ?? throw new InvalidOperationException("Jwt:Hace falta la llave.");
var jwtIssuer = builder.Configuration["Jwt:Issuer"] ?? throw new InvalidOperationException("Jwt:Hace falta el Issuer.");
var jwtAudience = builder.Configuration["Jwt:Audience"] ?? throw new InvalidOperationException("Jwt:La audiencia no está.");
var secretKey = builder.Configuration["JwtSettings:SecretKey"];
var key = Encoding.ASCII.GetBytes(secretKey);

// Agregar servicios de autenticación y autorización
builder.Services.AddAuthentication("Bearer")
    .AddJwtBearer("Bearer", options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtIssuer,
            ValidAudience = jwtAudience,
            IssuerSigningKey = new SymmetricSecurityKey(key)
        };
    });

builder.Services.AddAuthorization();

// Inyección de dependencias para servicios personalizados
builder.Services.AddHttpClient();
builder.Services.AddControllers();
builder.Services.AddScoped<ITokenStorage, InMemoryTokenStorage>();
builder.Services.AddScoped<ILoginAPIService, LoginAPIService>();
builder.Services.AddScoped<CustomAuthStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
//Tambien agregue estos
builder.Services.AddDbContext<DBContext>(options =>
    options.UseSqlite("Data Source=BaseDatosPECI.db"));




builder.Services.AddDbContext<DBContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));


// Blazor y componentes interactivos
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddCascadingAuthenticationState();

var app = builder.Build();

// 🌐 Configuración del pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseBlazorFrameworkFiles();

app.UseAuthentication();
app.UseAuthorization();

app.UseAntiforgery();

app.MapControllers();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(SistemaPECI.Client._Imports).Assembly);

app.Run();
