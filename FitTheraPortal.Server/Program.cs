using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Supabase;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddControllers();
builder.Services.AddOpenApi();


var supabaseUrl = builder.Configuration["supabase:url"];
var supabaseKey = builder.Configuration["supabase:key"];

var supabaseOptions = new SupabaseOptions
{
    AutoRefreshToken = true,
    AutoConnectRealtime = true
};

var supabase = new Supabase.Client(supabaseUrl, supabaseKey, supabaseOptions);

builder.Services.AddScoped<Supabase.Client>(provider => new Supabase.Client(supabaseUrl, supabaseKey, supabaseOptions));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();