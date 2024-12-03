using Firewall;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

#region 設定軟體防火牆

var allowCountryCodes = new List<CountryCode>
{
    CountryCode.TW
};

var rule = FirewallRulesEngine.DenyAllAccess()
                              .ExceptFromCountries(allowCountryCodes);

// 註冊防火牆中介層
app.UseFirewall(rule);

#endregion

// 設定 Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
