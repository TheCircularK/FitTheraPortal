using System.Net.Http.Headers;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using FitTheraPortal.Client;
using FitTheraPortal.Client.Automapper;
using FitTheraPortal.Client.DataServices.Implementations;
using FitTheraPortal.Client.DataServices.Interfaces;
using FitTheraPortal.Client.Repositories;
using FitTheraPortal.Client.Repositories.Implementations;
using FitTheraPortal.Client.Repositories.Interfaces;
using MudBlazor;
using MudBlazor.Services;
using Supabase;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Mudblazor services
builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.TopCenter;
});

// Supabase
var supabaseUrl = "https://onkpktfonshhyflnvfen.supabase.co";
var supabaseKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Im9ua3BrdGZvbnNoaHlmbG52ZmVuIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MzkzNjcxNjcsImV4cCI6MjA1NDk0MzE2N30.DFw6UT14zCSrdy2EZaoEOOpgp2tia8rpeLkhX-UxVMs";

var supabaseOptions = new SupabaseOptions
{
    AutoRefreshToken = true,
    AutoConnectRealtime = true
};

builder.Services.AddScoped<Supabase.Client>(provider => new Supabase.Client(supabaseUrl, supabaseKey, supabaseOptions));

// Scoped data services
builder.Services.AddScoped<IProfileDataService, ProfileDataService>();
builder.Services.AddScoped<IPatientDataService, PatientDataService>();
builder.Services.AddScoped<IInjuryDataService, InjuryDataService>();
builder.Services.AddScoped<IInjuryTreatmentPlanDataService, InjuryTreatmentPlanDataService>();

// Scoped repositories
builder.Services.AddScoped<IPatientRepository, PatientRepository>();
builder.Services.AddScoped<IProfileRepository, ProfileRepository>();
builder.Services.AddScoped<IInjuryRepository, InjuryRepository>();
builder.Services.AddScoped<IInjuryTreatmentPlanRepository, InjuryTreatmentPlanRepository>();

// Automapper
builder.Services.AddAutoMapper(typeof(MapperProfile));

// Blazor Bootstrap
builder.Services.AddBlazorBootstrap();

builder.Services.AddOidcAuthentication(options =>
{
    builder.Configuration.Bind("Auth0", options.ProviderOptions);
    options.ProviderOptions.ResponseType = "code";
    options.ProviderOptions.AdditionalProviderParameters.Add("audience", builder.Configuration["Auth0:Audience"]);
});

await builder.Build().RunAsync();