using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Shopping.Data;
using Shopping.DTOs;
using Shopping.Entites;
using Shopping.Errors;
using Shopping.IServices;
using Shopping.Models;

namespace Shopping.Services
{
    public class AccountService : IAccountService
    {
        public readonly DataContext _db;
        public readonly IMapper _mapper;
        public readonly ITokenService _tokenService;
        //public readonly IPhotoService _photoService;
        private readonly UserManager<AppUser> _userManager;


        public AccountService(DataContext db, ITokenService tokenService, IMapper mapper, UserManager<AppUser> userManager)
        {
            _db = db;
            _tokenService = tokenService;
            //_photoService = photoService;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<AddressResponseDTO> GetUserAddress(Guid userId)
        {
            AppUser? user = await _db.AppUsers.Include(x=>x.Address).AsNoTracking().SingleOrDefaultAsync(x => x.Id == userId);
            if (user == null)
            {
                throw new UnauthorizedAccessException("user invalid");
            }
            if (user.Address == null)
            {
                user.Address = new Address();
                _db.Users.Update(user);
                await _db.SaveChangesAsync();
            }
                return _mapper.Map<AddressResponseDTO>(user.Address);
        }

        public async Task<AddressResponseDTO> UpdateAddress(Guid userId, AddressResponseDTO model)
        {
            AppUser? user = await _db.AppUsers.Include(x => x.Address).AsNoTracking().SingleOrDefaultAsync(x => x.Id == userId);
            if (user == null)
            {
                throw new UnauthorizedAccessException("user invalid");
            }
            if(user.Address == null)
            {
                user.Address = new Address();
            }
            user.Address.Region  = model.Region;
            user.Address.City = model.City;
            user.Address.Details = model.Details;
            _db.Users.Update(user);
            await _db.SaveChangesAsync();
            
            return _mapper.Map<AddressResponseDTO>(user.Address);
        }

        public async Task<LoginResponseDTO> Login(string email, string password)
        {
            AppUser? user = await _db.AppUsers.AsNoTracking().SingleOrDefaultAsync(x => x.UserName == email);

            if (user == null)
            {
                throw new UnauthorizedAccessException("user invalid");
            }

            if (!await _userManager.CheckPasswordAsync(user, password))
            {
                throw new UnauthorizedAccessException("login invalid");
            }

            return new LoginResponseDTO()
            {
                Token = await _tokenService.CreateToken(user),
                UserName = user.UserName,
                //= _mapper.Map<InstitutionModel>(institution),
            };
        }
        public async Task<LoginResponseDTO> Register(RegisterRequestDTO model)
        {
            AppUser? user = await _db.AppUsers.SingleOrDefaultAsync(x => x.UserName == model.UserName || x.Email == model.Email);
            if (user != null)
            {
                throw new AppException("account already registerd");
            }

            user = new AppUser
            {
                UserName = model.UserName,
                Email = model.Email,
                
            };

            //if (model.Image != null)
            //{
            //    var result = await _photoService.AddPhotoAsync(model.Image);
            //    if (result.Error != null) throw new Exception(result.Error.Message);
            //    user.ImageUrl = result.Url.AbsoluteUri;
            //    user.ImageId = result.PublicId;
            //}

            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
               throw new AppException("User register field");

            await _userManager.AddToRoleAsync(user, "AppUser");

            return new LoginResponseDTO()
            {
                UserName =user.UserName,
                Token = await _tokenService.CreateToken(user),
            };
        }

        public async Task<AppUserResponseDTO> GetUserById(Guid Id)
        {
            AppUser? user = await _db.AppUsers.Include(x=>x.Address).SingleOrDefaultAsync(x=>x.Id == Id);
            if (user == null)
            {
                throw new KeyNotFoundException("account not exist");
            }
            return _mapper.Map<AppUserResponseDTO>(user);
        }


        public async Task UpdateUserProfile(Guid userId, AppUserResponseDTO model)
        {
            AppUser? user = await _db.AppUsers.AsNoTracking().SingleOrDefaultAsync(x => x.Id == userId);
            if (user == null)
            {
                throw new UnauthorizedAccessException("user invalid");
            }
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.PhoneNumber = model.PhoneNumber;
            _db.Users.Update(user);
            await _db.SaveChangesAsync();
        }
    }
}
