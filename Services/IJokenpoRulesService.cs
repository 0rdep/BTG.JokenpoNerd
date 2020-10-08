using BTG.JokenpoNerd.DTO;

namespace BTG.JokenpoNerd.Services
{
    public interface IJokenpoRulesService
    {
        JokenpoResultEnum GetJokenpoPlayResult(JokenpoSymbolEnum playerOneSymbol, JokenpoSymbolEnum playerTwoSymbol);
    }
}