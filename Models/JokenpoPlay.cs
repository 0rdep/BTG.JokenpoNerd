using System.ComponentModel.DataAnnotations;

namespace BTG.JokenpoNerd.DTO
{
    public class JokenpoPlay
    {
        [Required]
        public JokenpoPlayer PlayerOne { get; set; }

        [Required]
        public JokenpoPlayer PlayerTwo { get; set; }
    }
}