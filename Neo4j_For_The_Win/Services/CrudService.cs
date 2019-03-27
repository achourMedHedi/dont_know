using Neo4j_For_The_Win.Contracts;
using Neo4j_For_The_Win.EntityLayer.Nodes;
using System;
using Microsoft.Extensions;
using Neo4j_For_The_Win.Repositories;
using System.Threading.Tasks;
using Neo4j_For_The_Win.EntityLayer.Relationships;
using Neo4jClient;
using Neo4jClient.DataAnnotations;
using System.Collections;

namespace Neo4j_For_The_Win.Services
{
    public class CrudService : ICrudService
    {
       // ILogger Logger;
        ICrudReposiory CrudReposiory;
        IGraphClient Client;
        public CrudService (IGraphClient graphClient )
        {
            CrudReposiory = new CrudRepository(graphClient);
            Client = graphClient;

        }
        public async Task<bool> Add(WorkdsInRelationship worksInRelationship)
        {
            try
            {
                CrudReposiory.Add(worksInRelationship);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public IEnumerable Find()
        {

            try
             {
                 var result =  CrudReposiory.Find();
                return result;
             }
             catch (Exception)
             {
                 return null;
                 throw;
             }

        }
        
    }
}
