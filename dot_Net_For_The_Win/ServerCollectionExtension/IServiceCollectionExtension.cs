using Auth.Core.Contract;
using Auth.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using Neo4j.Driver.V1;
using Neo4j_For_The_Win.Contracts;
using Neo4j_For_The_Win.Repositories;
using Neo4j_For_The_Win.Services;
using Neo4jClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dot_Net_For_The_Win.ServerCollectionExtension
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddAuth(this IServiceCollection services)
        {
            services.AddScoped < IUserAuth , UserService > ();
            return services;
        }
        public static IServiceCollection AddNeo4j(this IServiceCollection services)
        {
            var client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "Aze123qsd456");

            services.AddSingleton<IGraphClient>(client);
            //services.AddSingleton<IDriver>(provider => GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "Aze123qsd456")));
            return services;
        }
        public static IServiceCollection AddNeo4jForTheWin(this IServiceCollection services)
        {
            services.AddScoped<ICrudService, CrudService>();
            return services;
        }


    }
}
