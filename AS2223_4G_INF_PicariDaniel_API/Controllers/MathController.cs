using Microsoft.AspNetCore.Mvc;

namespace AS2223_4G_INF_PicariDaniel_API.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/v1")]
    public class MathController : Controller
    {
        [HttpGet("NumeroPariDispari")]
        public JsonResult PariDispari(int numero)
        {
            string risultato;
            string status;
            if(numero %  2  == 0)
            {
                status = "ok";
                risultato = "il numero è pari";
            }
            else
            {
                status = "ko";
                risultato = "il numero è dispari";
            }
            return Json(new {output=numero,risultato=risultato,status=status});
        }
        [HttpGet("Fattoriale")]
        public JsonResult Fattoriale(int numero)
        {
            string status="ok";
            int risultato=1;
            for(int i = numero; i > 0; i--)
            {
                risultato = risultato * i;
                
            }

            return Json(new { output = numero , risultato = risultato , status=status});
        }
    }
}
