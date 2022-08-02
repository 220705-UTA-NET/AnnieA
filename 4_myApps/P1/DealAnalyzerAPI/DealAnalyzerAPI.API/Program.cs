using DealAnalyzerAPI.Data;

var builder = WebApplication.CreateBuilder(args);

string connectionString = await File.ReadAllTextAsync("C:/Users/annie/ConnectionStrings/P1-SQL-DB.txt");
//var connectionString = builder.Configuration.GetConnectionString("connectionString");

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IRepository>(sp => new SQLRepository(connectionString, sp.GetRequiredService<ILogger<SQLRepository>>()));

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
