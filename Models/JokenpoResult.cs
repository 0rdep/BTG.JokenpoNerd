using BTG.JokenpoNerd.DTO;

namespace BTG.JokenpoNerd.Models
{
    public class JokenpoResult
    {
        public JokenpoResultEnum Result { get; set; }
        public JokenpoPlayer Winner { get; set; }

        public JokenpoResult(JokenpoResultEnum result, JokenpoPlayer winner)
        {
            Result = result;
            Winner = winner;
        }
    }
}