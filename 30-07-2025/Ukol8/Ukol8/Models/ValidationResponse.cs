using Microsoft.AspNetCore.Mvc;

namespace Ukol8.Models
{
    public class ValidationResponse
    {
        public string Message { get; set; } = "Validace selhala";
        public List<string> Errors { get; set; } = new();
    }

}
