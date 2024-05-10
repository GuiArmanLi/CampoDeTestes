using Data.DTO;
using Data.Entities;

Console.WriteLine("Convertendo Fake Entity para DTO e vice versa!\n\n");

UserRequestDTO userRequestDTO = new UserRequestDTO()
{
    Username = "Guilherme",
    Password = "Admin",
    Email = "admin@email.com",
};
Console.WriteLine($"DTO de request criada: {userRequestDTO.ToString()}");

User user = (User)userRequestDTO;
Console.WriteLine($"DTO convertido para User: {user.ToString()}");

UserResponseDTO userResponseDTO = (UserResponseDTO)user;
Console.WriteLine($"User convertido para DTO de response: {userResponseDTO.ToString()}");
