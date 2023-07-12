using API_Placa.Models;
using API_Placa.Services;
using API_Placa.ViewModelResult;
using Microsoft.AspNetCore.Mvc;

namespace API_Placa.Controllers
{
    [ApiController]
    public class PlacaController : Controller
    {
        [HttpGet("/{placa}")]
        public async Task<IActionResult> VerificaPlaca(string placa)
        {
            var InfoCarro = PreencheLista.Site(placa);
            if (InfoCarro is null)
                return NotFound(new Result<string>("Carro Não Encontrado, Verifica o Numero da Placa"));
            
            return Ok(new Result<Carro>(InfoCarro));
        }

    }
}
