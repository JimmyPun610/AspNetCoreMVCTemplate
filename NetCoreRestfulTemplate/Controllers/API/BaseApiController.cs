using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreRestfulTemplate.Controllers.API
{
    public class BaseApiController : Controller
    {
        public IConfiguration Configuration;
        public BaseApiController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
    }
}
