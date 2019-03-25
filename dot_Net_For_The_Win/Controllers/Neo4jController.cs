using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Neo4j.Driver.V1;
using Neo4j_For_The_Win.Contracts;
using Neo4jClient.Extension;
using Neo4jClient.Extension.Cypher;
using Newtonsoft.Json;
using Neo4jClient.DataAnnotations;
using Neo4j_For_The_Win.Entities;
using Neo4jClient;
using System.Collections;

namespace dot_Net_For_The_Win.Controllers
{

    public class Relation
    {
        public TeamNode Relative { get; set; }
        public string Relationship { get; set; }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class Neo4jController : ControllerBase
    {

        private readonly IMoviesRepository _moviesRepository;
        private readonly IGraphClient client;

        public Neo4jController(IGraphClient client , IMoviesRepository moviesRepository)
        {
            _moviesRepository = moviesRepository;
            this.client = client;
        }
        // GET: api/Neo4j

        /// <summary>
        /// Get All Teams
        /// </summary>
        /// <response code="200"> success </response>
        /// <returns></returns>
        [ProducesResponseType(typeof(TeamNode), 200)]
        [ApiExplorerSettings(GroupName = "v1")]

        [HttpGet(Name = "GetAllTeams")]
        public IActionResult Get()
        {
            
            return Ok(_moviesRepository.GetTeams());
        }

      
    }
}
