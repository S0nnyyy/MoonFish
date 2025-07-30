using System.ComponentModel.DataAnnotations;

namespace Ukol9.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Jméno je povinné")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Příjmení je povinné")]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Špatně naformátován email")]
        public string Email { get; set; }
        [Phone(ErrorMessage = "Špatně naformátován telefon")]
        public string PhoneNumber { get; set; }

    }
}
