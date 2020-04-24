using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreMVCTemplate.Controllers.API
{

    [Route("api/ToDo")]
    public class ToDoController : BaseApiController
    {
        private readonly ILogger<ToDoController> _logger;

        public ToDoController(ILogger<ToDoController> logger, IConfiguration configuration) : base(configuration)
        {
            _logger = logger;            
        }

        /// <summary>
        /// This is testing get method api, will return value of CurrentHost in appsettings.json
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Test")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Exception), StatusCodes.Status500InternalServerError)]
        public IActionResult TestGet()
        {
            _logger.LogInformation("Test HttpGet Triggered");
            return Ok($"Test HttpGet success from {Configuration["CurrentHost"]}");
        }

        [HttpPost]
        [Route("Test")]
        [ProducesResponseType(typeof(string[]), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Exception), StatusCodes.Status500InternalServerError)]
        public IActionResult TestPost()
        {
            _logger.LogInformation("Test HttpPost Triggered");
            return Ok(new string[] { "Congratulation", "Test HttpPost success" });
        }
    }
}
