var builder = DistributedApplication.CreateBuilder(args);

var apiservice = builder.AddProject<Projects.repro_aspire_portforward_ApiService>("apiservice");

builder.AddProject<Projects.repro_aspire_portforward_Web>("webfrontend")
    .WithReference(apiservice);

builder.Build().Run();
