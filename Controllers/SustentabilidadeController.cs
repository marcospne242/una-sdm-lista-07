using Microsoft.AspNetCore.Mvc;

namespace EcoTrackApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SustentabilidadeController : ControllerBase
    {
        private readonly string[] _dicas = new[]
        {
            "Use lâmpadas de LED para economizar energia.",
            "Evite impressões desnecessárias de papel.",
            "Pratique o consumo consciente de água.",
            "Recicle seu lixo eletrônico em postos autorizados.",
            "Reduza o consumo de carne pelo menos uma vez por semana."
        };

        [HttpGet]
        public string GetDica()
        {
            var random = new Random();
            return _dicas[random.Next(_dicas.Length)];
        }
    }
}