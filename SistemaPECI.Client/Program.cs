﻿using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using SistemaPECI.Client;
using SistemaPECI.Client.Interfaces;
using SistemaPECI.Client.Seguridad;
using SistemaPECI.Client.Servicios;
using System.Data.Common;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped<ITokenStorage, InMemoryTokenStorage>();
builder.Services.AddScoped<CustomAuthStateProvider>(); 
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddScoped<ILoginAPIService, LoginAPIService>();
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://localhost:7098/")
});
builder.Services.AddAuthorizationCore();




await builder.Build().RunAsync();
