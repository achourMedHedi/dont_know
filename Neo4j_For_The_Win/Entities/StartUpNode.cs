using Neo4jClient.Extension.Cypher.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Neo4j_For_The_Win.Entities
{
    [CypherLabel(Name ="StartUp")]
    public class StartUpNode
    {
    
        [CypherMatch]
        public string Name { get; set; }
        
        [CypherMergeOnCreate]
        public ICollection<TeamNode> Teams { get; set; }
    }
}
