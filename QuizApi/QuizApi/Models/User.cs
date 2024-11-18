using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Security.Cryptography;

namespace QuizApi.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Platform { get; set; }
    }
}
