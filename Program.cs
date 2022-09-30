using HotChocolate.Execution.Batching;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddType<UnsignedShortType>()
                .AddType<UnsignedLongType>()
                .BindRuntimeType<ulong, UnsignedLongType>()
                .AddQueryType<Query>()
                .AddFiltering()
                .AddSorting()
                .AddProjections()
                // .AddType<UnsignedLongType>()
                ;

var app = builder.Build();

app.MapGraphQL();

app.Run();
