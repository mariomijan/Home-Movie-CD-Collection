using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCHTTPClient.Models
{
    public class LoginviewModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Username is required !")]
        [EmailAddress(ErrorMessage = "Invalid Email Address !")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required !")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}