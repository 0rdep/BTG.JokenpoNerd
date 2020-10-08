using BTG.JokenpoNerd.DTO;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BTG.JokenpoNerd.Services
{
    public class JokenpoRulesService : IJokenpoRulesService
    {
        private readonly ILogger<JokenpoRulesService> _logger;

        private Dictionary<JokenpoSymbolEnum, JokenpoSymbolEnum[]> WinConditions = new Dictionary<JokenpoSymbolEnum, JokenpoSymbolEnum[]>() {
            { JokenpoSymbolEnum.Scissors, new JokenpoSymbolEnum[]{ JokenpoSymbolEnum.Paper, JokenpoSymbolEnum.Lizard} },
            { JokenpoSymbolEnum.Paper, new JokenpoSymbolEnum[]{ JokenpoSymbolEnum.Rock, JokenpoSymbolEnum.Spock} },
            { JokenpoSymbolEnum.Rock, new JokenpoSymbolEnum[]{ JokenpoSymbolEnum.Scissors, JokenpoSymbolEnum.Lizard} },
            { JokenpoSymbolEnum.Lizard, new JokenpoSymbolEnum[]{ JokenpoSymbolEnum.Paper, JokenpoSymbolEnum.Spock} },
            { JokenpoSymbolEnum.Spock, new JokenpoSymbolEnum[]{ JokenpoSymbolEnum.Scissors, JokenpoSymbolEnum.Rock} }
        };

        public JokenpoRulesService(ILogger<JokenpoRulesService> logger)
        {
            _logger = logger;
        }

        public JokenpoResultEnum GetJokenpoPlayResult(JokenpoSymbolEnum playerOneSymbol, JokenpoSymbolEnum playerTwoSymbol)
        {
            if (playerOneSymbol == playerTwoSymbol)
            {
                _logger.LogInformation("Symbols are equal, Draw");
                return JokenpoResultEnum.Draw;
            }

            _logger.LogInformation($"Getting win conditions to symbol {playerOneSymbol}");
            var playerOneWinConditions = WinConditions[playerOneSymbol];

            if (playerOneWinConditions.Contains(playerTwoSymbol))
            {
                _logger.LogInformation($"Symbol {playerOneSymbol} won");
                return JokenpoResultEnum.PlayerOneWin;
            }
            else
            {
                _logger.LogInformation($"Symbol {playerOneSymbol} won");
                return JokenpoResultEnum.PlayerTwoWin;
            }
        }
    }
}