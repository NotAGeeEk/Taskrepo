using System.ComponentModel.DataAnnotations;

namespace WebAppUsers.Models
{
    public class User
    {
        [Required]
        public int userId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string UserPwd { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string UserEmail { get; set; }

    }
}
