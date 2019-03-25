using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Neo4jClient.DataAnnotations.Serialization;
namespace Neo4j_For_The_Win.Entities
{
    public class Movie
    {
        public string title { get; set; }
        public int released { get; set; }
    }
}
