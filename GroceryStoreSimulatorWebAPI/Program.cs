using GroceryStoreSimulatorWebAPI.DataAccess;
using GroceryStoreSimulatorWebAPI.DataAccess.Repositories;
using GroceryStoreSimulatorWebAPI.GraphQL;
using GroceryStoreSimulatorWebAPI.Models;
using GroceryStoreSimulatorWebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddTransient(typeof(OrderService));
builder.Services.AddTransient(typeof(StoreService));
builder.Services.AddTransient(typeof(OrderDetailService));
builder.Services.AddTransient(typeof(OrderRepository));
builder.Services.AddTransient(typeof(BaseRepository<>));




builder.Services.AddCors(options => options.AddPolicy("AllowAll",p =>
{
    p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().Build();
}));




builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddType<OrderType>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}

app.UseHttpsRedirection();


app.UseCors("AllowAll");



app.UseRouting().UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});




app.UseAuthorization();

app.MapControllers();


app.Run();
