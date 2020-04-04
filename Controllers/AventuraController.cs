using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RPGServer.Extensions;
using RPGServer.Mocks;
using RPGServer.Models;

namespace RPGServer.Controllers
{
    [ApiController]
    [Route("gerador/[controller]")]
    public class AventuraController : ControllerBase
    {
        private readonly ILogger<AventuraController> _logger;

        public AventuraController(ILogger<AventuraController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Aventura GetAventura()
        {
            return AventuraMock.GetAventuras().PickRandom();
        }
    }
}