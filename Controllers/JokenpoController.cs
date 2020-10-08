using BTG.JokenpoNerd.DTO;
using BTG.JokenpoNerd.Models;
using BTG.JokenpoNerd.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BTG.JokenpoNerd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JokenpoController : ControllerBase
    {
        private readonly ILogger<JokenpoController> _logger;
        private readonly IJokenpoService _jokenpoService;

        public JokenpoController(ILogger<JokenpoController> logger, IJokenpoService jokenpoService)
        {
            _logger = logger;
            _jokenpoService = jokenpoService;
        }

        [HttpPost("Play")]
        public JokenpoResult Play(JokenpoPlay play)
        {
            _logger.LogInformation($"Playing new game");
            _logger.LogInformation($"Player [{play.PlayerOne.Name}] chose [{play.PlayerOne.ChosenJokenpoSymbol}]");
            _logger.LogInformation($"Player [{play.PlayerTwo.Name}] chose [{play.PlayerTwo.ChosenJokenpoSymbol}]");
            return _jokenpoService.Play(play);
        }
    }
}