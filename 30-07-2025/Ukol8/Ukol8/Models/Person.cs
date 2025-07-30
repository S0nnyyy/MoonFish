
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Ukol8.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Jméno je povinné.")]
        public string FirstName { get; set; }
        [Range(1, 120, ErrorMessage = "Věk je mimo limit")]
        public int Age { get; set; }
        [EmailAddress(ErrorMessage = "Neplatný formát emailu.")]
        public string Email { get; set; }



    }

}
