using Neo4jClient.Extension.Cypher.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Neo4j_For_The_Win.EntityLayer.Nodes
{ 
    [CypherLabel(Name ="StartUp")]
    [Table("StartUp")]
    public class Company
    {
        public string Name { get; set; }

    }
}
