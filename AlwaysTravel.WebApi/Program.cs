using AlwaysTravel.ApplicationCore.Interfaces.IRepository;
using AlwaysTravel.ApplicationCore.Interfaces.IService;
using AlwaysTravel.ApplicationCore.Services;
using AlwaysTravel.Infrastructure.Repository;
using RepoDb;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IPackageRepository, PackageRepository>();
builder.Services.AddSingleton<IStageRepository, StageRepository>();
builder.Services.AddSingleton<ITravelRepository, TravelRepository>();
builder.Services.AddSingleton<ITravelHasStageRepository, TravelHasStageRepository>();

builder.Services.AddSingleton<IPackageService, PackageService>();
builder.Services.AddSingleton<IStageService, StageService>();
builder.Services.AddSingleton<ITravelService, TravelService>();
builder.Services.AddSingleton<ITravelHasStageService, TravelHasStageService>();


RepoDb.SqlServerBootstrap.Initialize();

string MyAllowSpecificOrigins = "_myAllowSpecificOrigin";


builder.Services.AddCors(o => o.AddPolicy(MyAllowSpecificOrigins, builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
}));


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
