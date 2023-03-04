using API_WebApp.MinimalAPIs;
using API_WebApp.RegisterServices;
using API_WebApp.Services;

var builder = WebApplication.CreateBuilder(args);

//the below acts as the configure service method of the start up class

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//adding service can be done in following two ways
new RegisterServices(builder.Services).Services();
Princess(builder.Services);

var app = builder.Build();

//the below acts as the configure method of startup class

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/", () => "Hello world");
app.MapGet("/tester", () => new TestService().Tester());

new UserApIs().RegisterApIs(app);

app.Run();

void Princess(IServiceCollection serviceCollection)
{
    serviceCollection.AddAntiforgery();
}

//dotnet run --environment Development