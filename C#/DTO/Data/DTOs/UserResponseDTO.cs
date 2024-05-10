using Data.Entities;

namespace Data.DTO
{
    public class UserResponseDTO
    {
        public required string Username { get; set; }
        public required string Password { get; set; }

        public override string ToString()
        {
            return $"Username {Username} Password {Password}";
        }

        public static implicit operator UserResponseDTO(User user)
        {
            return new UserResponseDTO
            {
                Username = user.Username,
                Password = user.Password
            };
        }
    }
}