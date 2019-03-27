using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Auth.Core.Contract;
using Auth.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dot_Net_For_The_Win.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private IUserAuth _userService;
        private ILogger _logger;
        public AuthController(IUserAuth userService , ILogger logger)
        {
            _logger = logger;
            _userService = userService;
        }
        // GET api/Auth/admin
        /// <summary>
        /// get admin account information
        /// </summary>
        /// <response code="200"> success </response>
        /// <response code="400"> wrong token </response>
        /// <returns></returns>
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(typeof(string), 200)]
        [ApiExplorerSettings(GroupName = "v1")]

        [Authorize(Roles = "admin")]
        [HttpGet("admin", Name = "SignInAsAdministrator")]
        public IActionResult  GetAdmin()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            IEnumerable<Claim> claims = identity.Claims;
            var result = claims.Select(x => x.Value);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }
        // GET api/Auth/student

        /// <summary>
        /// get student account information
        /// </summary>
        /// <response code="200"> success </response>
        /// <response code="400"> wrong token </response>
        /// <returns></returns>
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(typeof(string), 200)]
        [ApiExplorerSettings(GroupName = "v1")]

        [Authorize(Roles = "student")]
        [HttpGet("student", Name = "SignInAsstudent")]
        public IActionResult GetStudnet()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            IEnumerable<Claim> claims = identity.Claims;
            var result = claims.Select(x => x.Value);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        // POST api/auth

        /// <summary>
        /// sign in
        /// </summary>
        /// <response code="200"> success </response>
        /// <response code="400"> wrong informations </response>
        /// <returns></returns>
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(typeof(string), 200)]
        [ApiExplorerSettings(GroupName = "v1")]

        [HttpPost(Name = "SignIn")]
        public async Task<IActionResult> Post([FromBody] User userParams)
        {
            var user = await _userService.AuthenticateAsync(userParams.Username, userParams.Password);
            if (user == null)
            {
                return BadRequest();

            }
            return Ok(user);
        }

       
    }
}
