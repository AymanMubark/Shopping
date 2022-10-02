using Microsoft.Win32;
using Shopping.DTOs;
using Shopping.Models;

namespace Shopping.IServices
{
    public interface IAccountService
    {
        public Task<LoginResponseDTO> Login(string email, string password);
        public Task<LoginResponseDTO> Register(RegisterRequestDTO model);
    }
}
