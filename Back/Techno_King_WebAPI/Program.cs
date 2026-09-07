using App.Domain.Core.Techno_King.App.Domain.Core;
using App.Domain.Core.Techno_King.Config;
using App.Domain.Core.Techno_King.Data.Repositories;
using App.Domain.Core.Techno_King.Entities.Users;
using App.Domain.Core.Techno_King.Enum;
using App.Domain.Core.Techno_King.Service;
using App.Infra.Data.Repos.Ef.Techno_King;
using Connection.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;
using Serilog;
using System;
using System.Reflection;
using Techno_KingAppService.Techno_King.Categories;
using Techno_KingAppService.Techno_King.Products;
using Techno_KingAppService.Techno_King.Users;
using Techno_KingService.Techno_King.Categories;
using Techno_KingService.Techno_King.Products;
using Techno_KingService.Techno_King.Techno_GeneralService;
using Techno_KingService.Techno_King.Users;


Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);

// --- Load SiteSettings from the built-in configuration ---
// This automatically includes appsettings.json, environment variables, etc.
var siteSettings = builder.Configuration.GetSection("SiteSettings").Get<Sitesettings>();
builder.Services.AddSingleton(siteSettings);

// --- Configure Serilog using the loaded SiteSettings ---
builder.Host.UseSerilog((context, config) =>
{
    config.WriteTo.Console();
    config.WriteTo.Seq(siteSettings.SeqConfigurations.UrlAddress, apiKey: siteSettings.SeqConfigurations.ApiToken);
});

builder.Services.AddMemoryCache();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(siteSettings.SqlConfigurations.ConnectionString,
        x => x.MigrationsAssembly("Connection")));

builder.Services.AddIdentity<UserBase, IdentityRole<int>>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
})
.AddRoles<IdentityRole<int>>()
.AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductAppService, ProductAppService>();
builder.Services.AddScoped<IGeneralService, GeneralService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserAppService, UserAppService>();
builder.Services.AddScoped<ICategoriesRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryAppService, CategoryAppService>();

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// --- CORS Configuration (Global access for development) ---
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

app.UseCors();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Techno_King API v1");
        c.RoutePrefix = string.Empty;
    });
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.UseStaticFiles();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<AppDbContext>();
        context.Database.Migrate();

        Log.Information("Database migrated successfully.");
    }
    catch (Exception ex)
    {
        Log.Error(ex, "An error occurred while migrating the database.");
    }
}

try
{
    app.Run();
}
catch (Exception ex)
{
    Log.Error(ex, "An error occurred while starting the application");
    if (ex is ReflectionTypeLoadException reflEx)
    {
        foreach (var loaderEx in reflEx.LoaderExceptions)
        {
            Log.Error(loaderEx, "Loader Exception: {Message}", loaderEx.Message);
        }
    }
}
finally
{
    Log.CloseAndFlush();
}
