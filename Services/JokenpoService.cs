using BTG.JokenpoNerd.DTO;
using BTG.JokenpoNerd.Models;
using Microsoft.Extensions.Logging;
using System;

namespace BTG.JokenpoNerd.Services
{
    public class JokenpoService : IJokenpoService
    {
        private readonly ILogger<JokenpoService> _logger;
        private readonly IJokenpoRulesService _jokenpoRulesService;

        public JokenpoService(ILogger<JokenpoService> logger, IJokenpoRulesService jokenpoRulesService)
        {
            _logger = logger;
            _jokenpoRulesService = jokenpoRulesService;
        }

        public JokenpoResult Play(JokenpoPlay play)
        {
            _logger.LogInformation($"Getting play result");
            var playResult = _jokenpoRulesService.GetJokenpoPlayResult(play.PlayerOne.ChosenJokenpoSymbol, play.PlayerTwo.ChosenJokenpoSymbol);
            _logger.LogInformation($"Play result: {playResult}");

            return playResult switch
            {
                JokenpoResultEnum.Draw => new JokenpoResult(playResult, null),
                JokenpoResultEnum.PlayerOneWin => new JokenpoResult(playResult, play.PlayerOne),
                JokenpoResultEnum.PlayerTwoWin => new JokenpoResult(playResult, play.PlayerTwo),
                _ => throw new Exception("Unexpected Result"),
            };
        }
    }
}