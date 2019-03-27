using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Neo4j.Driver.V1;
using Neo4jClient.Extension;
using Neo4jClient.Extension.Cypher;
using Newtonsoft.Json;
using Neo4jClient.DataAnnotations;
using Neo4jClient;
using System.Collections;
using Neo4j_For_The_Win.EntityLayer.Relationships;
using Neo4j_For_The_Win.Contracts;
using Neo4j_For_The_Win.EntityLayer.Nodes;

namespace dot_Net_For_The_Win.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class Neo4jController : ControllerBase
    {

        private readonly ICrudService crudService;
        private readonly IGraphClient client;

        public Neo4jController(IGraphClient client , ICrudService crudService)
        {
            this.crudService = crudService;
            this.client = client;
        }

        [HttpPost]
        public IActionResult PostAsync([FromBody] WorkdsInRelationship body)
        {
                       var result = crudService.Find();
                        if (result == null)
                        {
                            return BadRequest();
                        }
                        return Ok(result);
            


        }


    }
}
