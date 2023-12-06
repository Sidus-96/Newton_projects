using System.ComponentModel.DataAnnotations;

namespace GreenThumb.Models
{
    internal class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
