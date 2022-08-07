global using Blazor_LeadManagement_HDIP.Shared;
global using Blazor_LeadManagement_HDIP.Client.Services.LeadService;
global using Blazor_LeadManagement_HDIP.Client.Services.TaskService;
global using System.Net.Http.Json;
using Blazor_LeadManagement_HDIP.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ILeadService, LeadService>();
builder.Services.AddScoped<ITaskService, TaskService>();


await builder.Build().RunAsync();
