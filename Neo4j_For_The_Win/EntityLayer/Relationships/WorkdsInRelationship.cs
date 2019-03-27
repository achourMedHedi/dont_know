using Neo4j_For_The_Win.EntityLayer.Nodes;
using Neo4jClient.Extension.Cypher.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Neo4j_For_The_Win.EntityLayer.Relationships
{
    [CypherLabel(Name = LabelName)]
    [Table(LabelName)]
    public class WorkdsInRelationship
    {
        public const string LabelName = "WORKS_IN";


        public Team Team { get; set; }
        public Company Company { get; set; }


    }
}
