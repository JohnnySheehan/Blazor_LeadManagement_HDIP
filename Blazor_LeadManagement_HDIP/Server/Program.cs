global using Microsoft.EntityFrameworkCore;
global using Blazor_LeadManagement_HDIP.Shared;
global using Blazor_LeadManagement_HDIP.Server.Services.LeadService;
global using Blazor_LeadManagement_HDIP.Server.Data;
using Microsoft.AspNetCore.ResponseCompression;
//using Blazor_LeadManagement_HDIP.Server.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Blazor_LeadManagement_HDIP.Server.Data.AppContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();


builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<ILeadService, LeadService>();

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSwagger();

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
