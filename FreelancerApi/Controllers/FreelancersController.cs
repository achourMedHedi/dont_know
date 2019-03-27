using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FreelancerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreelancersController : ControllerBase
    {
        /// <summary>
        /// test names
        /// </summary>
        /// <returns></returns>
        [ProducesResponseType(typeof(string), 200)]
        [ApiExplorerSettings(GroupName = "v1")]
        // GET api/values
        [HttpGet(Name ="testNames")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Achour", "Arsslen" , "Raed" , "Yahya" , "Koussay" };
        }

        // GET api/values
        [HttpGet("test")]
        public ActionResult<IEnumerable<string>> GetTest()
        {
            return new string[] { "test" };
        }


    }
}
