using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(10,MinimumLength=4,ErrorMessage="Password should be between 4 to 10 characters")]
        public string Password { get; set; }
    }
}