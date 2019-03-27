using Neo4j_For_The_Win.Contracts;
using Neo4j_For_The_Win.EntityLayer.Nodes;
using Neo4j_For_The_Win.EntityLayer.Relationships;
using Neo4jClient;
using Neo4jClient.DataAnnotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Neo4j_For_The_Win.Repositories
{
    class CrudRepository : ICrudReposiory
    {
        private IGraphClient Client;

        public CrudRepository(IGraphClient graphClient)
        {
            this.Client = graphClient;
        }

        public void Add(WorkdsInRelationship worksInRelationship)
        {
            Console.WriteLine("helloooo");
            
        }

        public IEnumerable Find()
        {
            Client.Connect();
            return Client.WithAnnotations().Cypher.Match(p =>
                    p.Pattern<Team, WorkdsInRelationship, Company>("t", "r", "c", RelationshipDirection.Outgoing)
                    .Constrain((t) => t.Name == "engineering"))
                    .Return((t, r, c) => new WorkdsInRelationship
                    {
                        Team = t.As<Team>(),
                        Company = c.As<Company>()
                    }).Results;
        }
    }
}
