using Data.Entities;

namespace Data.DTO
{
    public class UserRequestDTO
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public bool? ReceiveMessages { get; set; } = true;

        public override string ToString()
        {
            return $"Username {Username} Password {Password} Email {Email} ReceiveMessages {ReceiveMessages}";
        }

        public static implicit operator UserRequestDTO(User user)
        {
            return new UserRequestDTO()
            {
                Username = user.Username,
                Password = user.Password,
                Email = user.Email
            };
        }
    }
}