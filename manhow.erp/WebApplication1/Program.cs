using Firewall;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

#region �]�w�n�騾����

var allowCountryCodes = new List<CountryCode>
{
    CountryCode.TW
};

var rule = FirewallRulesEngine.DenyAllAccess()
                              .ExceptFromCountries(allowCountryCodes);

// ���U�����𤤤��h
app.UseFirewall(rule);

#endregion

// �]�w Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
