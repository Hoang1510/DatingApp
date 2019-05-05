using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(9,MinimumLength=4,ErrorMessage="The length must be between 9 and 4")]    
        public string Password { get; set; }    
    }
}