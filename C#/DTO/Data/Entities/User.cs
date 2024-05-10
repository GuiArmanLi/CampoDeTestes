using Data.DTO;

namespace Data.Entities
{
    public class User
    {
        public Guid Id { get; } = Guid.NewGuid();
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public bool? ReceiveMessages { get; set; }

        public override string ToString()
        {
            return $"Id {Id} Username {Username} Password {Password} Email {Email} ReceiveMessages {ReceiveMessages}";
        }

        public static implicit operator User(UserRequestDTO resquest)
        {
            return new User()
            {
                Username = resquest.Username,
                Password = resquest.Password,
                Email = resquest.Email,
                ReceiveMessages = resquest.ReceiveMessages,
            };
        }
    }
}