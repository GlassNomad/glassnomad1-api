var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

string authority builderConfiguration ["Auth0: Authority"] ?? 
throw new ArgumentNullException"Auth0: Authority"); 

string audience builderConfiguration ["Auth0: Audience"] ?? 
throw new ArgumentNullException"Auth0: Audience");

string storeConnectionString = builder.Configuration.GetConnectionString"StoreConnection") ?? 
throw new ArgumentNullException "ConnectionString: StoreConnection ";