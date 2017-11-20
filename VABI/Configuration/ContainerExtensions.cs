using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VABI.Models;
using VABI.Models.Utils;
using VABI.Repositories;

namespace VABI.Configuration
{
    public static class ContainerExtensions
    {
        public static IServiceCollection AddLegoCollectionServices(
               this IServiceCollection services)
        {
            services.AddTransient<IMapper<LegoBlock, Repositories.DTOs.LegoBlock>, LegoBlockMapper>();
            services.AddTransient<IMapper<LegoBlockCollected, Repositories.DTOs.LegoBlockCollected>, LegoBlockCollectedMapper>();
            services.AddTransient<IMapper<LegoSet, Repositories.DTOs.LegoSet>, LegoSetMapper>();
            services.AddTransient<IMapper<LegoCollection, Repositories.DTOs.LegoCollection>, LegoCollectionMapper>();

            services.AddSingleton<IDocumentClient, DocumentClient>(
                c => new DocumentClient(
                    new Uri(c.GetRequiredService<IOptions<LegoCollectorCosmosDbSettings>>().Value.EndpointUri),
                    c.GetRequiredService<IOptions<LegoCollectorCosmosDbSettings>>().Value.PrimaryKey));

            services.AddSingleton<IProvideLegoSets, LegoSetsCosmosDbRepository>();
            services.AddSingleton<ILegoSetsRepository,LegoSetsCosmosDbRepository>();
            services.AddSingleton<ILegoCollectionsRepository, LegoCollectionsCosmosDbRepository>();
            return services;
        }
    }
}
