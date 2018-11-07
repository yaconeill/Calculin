using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModeloCore;

namespace ApiWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversorController : ControllerBase
    {
		private ILogger<ConversorController> _logger;

		public ConversorController(ILogger<ConversorController> logger)
		{
			_logger = logger;
		}
	}
}