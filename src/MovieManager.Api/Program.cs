using MovieManager.Application;
using MovieManager.Infrastructure;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddApplication().AddInfrastructure(builder.Configuration);
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddCors(o => o.AddPolicy("frontend", builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
}));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("frontend");
app.UseHttpsRedirection();
app.MapControllers();
app.Run();
