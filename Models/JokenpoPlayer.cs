using System.ComponentModel.DataAnnotations;

namespace BTG.JokenpoNerd.DTO
{
    public class JokenpoPlayer
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public JokenpoSymbolEnum ChosenJokenpoSymbol { get; set; }
    }
}