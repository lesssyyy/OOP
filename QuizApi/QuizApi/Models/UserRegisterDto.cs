using System.ComponentModel.DataAnnotations;

namespace QuizApi.Models
{
    public class UserRegisterDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Platform { get; set; }
    }
}
