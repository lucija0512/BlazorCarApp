using BlazorCarDetailing.Data;
using CarDetailingDatabase;
using CarDetailingDatabase.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddTransient<IDatabaseAccess, DatabaseAccess>();
builder.Services.AddTransient<ICarsData, CarsData>();
builder.Services.AddTransient<IWashTypeData, WashTypeData>();
builder.Services.AddTransient<IExpenseData, ExpenseData>();
builder.Services.AddTransient<IAssetData, AssetData>();


var app = builder.Build();

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTY2MTAxQDMxMzkyZTM0MmUzMFNaeTd6Nk9CTnVEdjNWaDFIeFAxUHlYaDJoa3FRMzJZL3puM29XcmUrclE9");
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
