using System;
using System.Collections.Generic;
using System.Text;
using Neo4jClient.Cypher;

namespace Neo4j_For_The_Win.Entities
{
    public class RelationShip
    {
        public IEnumerable<TeamNode> Team { get; set; }
        //public IEnumerable<Object> Relations { get; set; }
        public StartUpNode StartUp { get; set; }
        public IEnumerable<string> RelationType { get; set; }

    }
}
