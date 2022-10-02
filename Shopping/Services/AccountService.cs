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

            await _userManager.CreateAsync(user, model.Password);

            await _userManager.AddToRoleAsync(user, "AppUser");

            return new LoginResponseDTO()
            {
                UserName =user.UserName,
                Token = await _tokenService.CreateToken(user),
            };
        }
    }
}
