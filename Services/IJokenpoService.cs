using BTG.JokenpoNerd.DTO;
using BTG.JokenpoNerd.Models;

namespace BTG.JokenpoNerd.Services
{
    public interface IJokenpoService
    {
        JokenpoResult Play(JokenpoPlay play);
    }
}