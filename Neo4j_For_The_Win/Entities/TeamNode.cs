using System;
using System.Collections.Generic;
using Neo4jClient.DataAnnotations.Cypher;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using Neo4jClient.Extension.Cypher.Attributes;

namespace Neo4j_For_The_Win.Entities
{
    [CypherLabel("Team")]
    public class TeamNode
    {
        [CypherMatch]
        public string Name { get; set; }
        
        [CypherMergeOnCreate]
        public StartUpNode Startup { get; set; }

    }
}
