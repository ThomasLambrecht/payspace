using Server.Services;
using Server.Services.Calculators.Interfaces;
using Server.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ITaxService, TaxService>();
builder.Services.AddScoped<ITaxCalculationTypeService, TaxCalculationTypeService>();
//builder.Services.AddScoped<ITaxCalculator, TaxCalculator>();
//builder.Services.AddScoped<IFlatRateTaxCalculator, FlatRateTaxCalculator>();
//builder.Services.AddScoped<IFlatValueTaxCalculator, FlatValueTaxCalculator>();
//builder.Services.AddScoped<IProgressiveTaxCalculator, ProgressiveTaxCalculator>();

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
