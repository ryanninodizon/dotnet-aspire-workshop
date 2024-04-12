var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.aspire_preview5_ApiService>("apiservice");

builder.AddProject<Projects.aspire_preview5_Web>("webfrontend")
    .WithReference(apiService);

builder.Build().Run();
