using Microsoft.Win32;
using Shopping.DTOs;
using Shopping.Models;

namespace Shopping.IServices
{
    public interface IAccountService
    {
        public Task<LoginResponseDTO> Login(string email, string password);
        public Task<LoginResponseDTO> Register(RegisterRequestDTO model);
        public Task<AddressResponseDTO> GetUserAddress(Guid userId);
        public Task<AddressResponseDTO> UpdateAddress(Guid userId,AddressResponseDTO model);
        public Task UpdateUserProfile(Guid userId,AppUserResponseDTO model);
        public Task<AppUserResponseDTO> GetUserById(Guid Id);
    }
}
