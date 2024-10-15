using Microsoft.AspNetCore.Mvc;

namespace MeuApp.Controllers
{
    [ApiController]
    [Route("/")] // Rota raiz
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Bem-vindo à API! Acesse /swagger para ver a documentação.");
        }
    }
}
