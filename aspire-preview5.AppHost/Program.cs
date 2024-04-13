var builder = DistributedApplication.CreateBuilder(args);



var appInsightsConnString = builder.Configuration["AppInsightsConnString"];

var apiService = builder.AddProject<Projects.aspire_preview5_ApiService>("apiservice")

.WithEnvironment("APPLICATIONINSIGHTS_CONNECTION_STRING",appInsightsConnString);
builder.AddProject<Projects.aspire_preview5_Web>("webfrontend")
    .WithReference(apiService)
    .WithEnvironment("APPLICATIONINSIGHTS_CONNECTION_STRING",appInsightsConnString);;

builder.Build().Run();
