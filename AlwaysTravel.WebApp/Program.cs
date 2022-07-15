using AlwaysTravel.ApplicationCore.Interfaces.IRepository;
using AlwaysTravel.ApplicationCore.Interfaces.IService;
using AlwaysTravel.ApplicationCore.Services;
using AlwaysTravel.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSingleton<IPackageRepository, PackageRepository>();
builder.Services.AddSingleton<IStageRepository, StageRepository>();
builder.Services.AddSingleton<ITravelRepository, TravelRepository>();
builder.Services.AddSingleton<ITravelHasStageRepository, TravelHasStageRepository>();

builder.Services.AddSingleton<IPackageService, PackageService>();
builder.Services.AddSingleton<IStageService, StageService>();
builder.Services.AddSingleton<ITravelService, TravelService>();
builder.Services.AddSingleton<ITravelHasStageService, TravelHasStageService>();


RepoDb.SqlServerBootstrap.Initialize();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
