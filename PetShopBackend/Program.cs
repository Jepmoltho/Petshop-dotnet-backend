using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using PetShopBackend.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PetShopContext>(options =>
    options.UseSqlite("Data Source=petshop.db"));
builder.Services.AddScoped<IPetRepository, PetRepository>(); //Added 

// Create a scope to access services
using (var scope = builder.Services.BuildServiceProvider().CreateScope()) //Added 
{
    var serviceProvider = scope.ServiceProvider;
    var context = serviceProvider.GetRequiredService<PetShopContext>();
    
    // Call the Initialize method to seed the database
    DbInitializer.Initialize(context);
}


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
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
