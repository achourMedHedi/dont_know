using Neo4j_For_The_Win.EntityLayer.Nodes;
using Neo4j_For_The_Win.EntityLayer.Relationships;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Neo4j_For_The_Win.Contracts
{
    public interface ICrudReposiory
    {
        void Add(WorkdsInRelationship worksInRelationship);
        IEnumerable Find();

    }
}
