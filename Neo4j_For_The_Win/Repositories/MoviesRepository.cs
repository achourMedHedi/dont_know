using Neo4j.Driver.V1;
using Neo4j_For_The_Win.Contracts;
using Neo4jClient;
using System.Collections.Generic;
using Neo4jClient.Extension.Cypher.Attributes;
using Neo4jClient.Extension.Cypher;
using Neo4j_For_The_Win.Entities;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Collections;

namespace Neo4j_For_The_Win.Repositories
{
    public class MoviesRepository : IMoviesRepository
    {
        private readonly IGraphClient client;

        public MoviesRepository(IGraphClient client)
        {
            this.client = client;
       
        }

        public IEnumerable<object> GetMovies()
        {
            throw new NotImplementedException();
        }

        /* public IEnumerable<object> GetMovies()
{
    //var client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "myPa55w0rd");


    var session = _driver.Session().WriteTransaction(tx => tx.Run("match (m:Movie) return properties(m)  ")).Select(x => x.Values.Values.FirstOrDefault());
    var nodeProps = JsonConvert.SerializeObject(session);
    return JsonConvert.DeserializeObject<List<Movie>>(nodeProps);

}*/

        public IEnumerable GetTeams()
        {
            /*var result = client.Cypher.Match(path => path.Pattern<StartUpNode, TeamNode>("team", "works_in", "startUp")).Return((startUp, team) => new
            {
                StartUp = startUp.As<StartUpNode>(),
                Team = team.As<TeamNode>()
            }).Results;*/
            client.Connect();
            /*var query = client.Cypher
            .Match("(person:Team)")
            .Return((person, startUp) => person.As<TeamNode>());*/

            /*foreach (var result in query.Results)
            {
                yield return Ok(result);
            }*/
            List<TeamNode> teamNode = new List<TeamNode>() { new TeamNode() { Name = "Business" } };
            /*
            client.Cypher
                 .Unwind(teamNode, "team")
                .Merge("(t:Team { Name : 'salem' })")
                .OnCreate()
                .Set("t = team")
                .ExecuteWithoutResults();
            */
            /*client.Cypher
                .Match("(t1:StartUp)", "(t2:Team)")
                .Where((StartUpNode t1) => t1.Name == "GoMyCode")
                .AndWhere((TeamNode t2) => t2.Name == "Business")
                .CreateUnique("(t1)-[:HAS_TEAM]->(t2)")
                .ExecuteWithoutResults();*/

            /* var query = client.Cypher
                 .Match("(p:Team { Name : {name} })")
                 .WithParams(new { name = "Business" })
                 .OptionalMatch("(p)-[r]->(s:StartUp)")
                 .With("p, {Relationship: type(r), Relative: s} as relations , s")
                 .Return((p, relations , s) => new RelationShip
                 {
                     Team = p.As<TeamNode>(),
                     Relations = relations.CollectAs<Relation>(),
                     StartUp = s.As<StartUpNode>()

                 });
             */
            var query2 = client.Cypher
                .Match("(s:StartUp { Name : {name} })")
                .WithParams(new { name = "GoMyCode" })
                .OptionalMatch("(s)-[r]-(t:Team)")
                .With("Distinct(t) as team , type(r) as relationType , s ")
                .Return((s, team, relationType) => new RelationShip
                {
                    StartUp = s.As<StartUpNode>(),
                    Team = team.CollectAs<TeamNode>(),
                    RelationType = relationType.CollectAs<string>()
                });

            return (query2.Results);
        }

    
    }
}
