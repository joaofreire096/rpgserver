using Microsoft.AspNetCore.Mvc;
using RPGServer.Extensions;
using RPGServer.Mocks;
using RPGServer.Models;

namespace RPGServer.Controllers
{
    [ApiController]
    [Route("gerador/[controller]")]
    public class CidadeController : ControllerBase
    {
        [HttpGet]
        public Cidade GetCidade()
        {
            return CidadeMock.GetCidades().PickRandom();
        }
    }
}