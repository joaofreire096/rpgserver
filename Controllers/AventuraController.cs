﻿using Microsoft.AspNetCore.Mvc;
using RPGServer.Extensions;
using RPGServer.Mocks;
using RPGServer.Models;

namespace RPGServer.Controllers
{
    [ApiController]
    [Route("gerador/[controller]")]
    public class AventuraController : ControllerBase
    {
        [HttpGet]
        public Aventura GetAventura()
        {
            return AventuraMock.GetAventuras().PickRandom();
        }
    }
}