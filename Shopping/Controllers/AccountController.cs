using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shopping.DTOs;
using Shopping.Extensions;
using Shopping.IServices;
using Shopping.Models;

namespace Shopping.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly IAccountService accountService;

        public AccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<ActionResult<LoginResponseDTO>> Login(LoginRequestDTO model)
        {
            return await accountService.Login(model.UserName, model.Password);
        }
        [AllowAnonymous]
        [HttpPost("Register")]
        public async Task<ActionResult<LoginResponseDTO>> Register(RegisterRequestDTO model)
        {
            return Ok(await accountService.Register(model));
        }

        [HttpGet("Address/me")]
        public async Task<ActionResult<AddressResponseDTO>> GetUserAddress()
        {
            return await accountService.GetUserAddress(User.GetUserId());
        }

        [HttpPut("Address/me")]
        public async Task<ActionResult<AddressResponseDTO>> UpdateUserAddress(AddressResponseDTO model)
        {
            return await accountService.UpdateAddress(User.GetUserId(),model);
        }

        [HttpGet("me")]
        public async Task<ActionResult<AppUserResponseDTO>> GetUser()
        {
            return await accountService.GetUserById(User.GetUserId());
        }

        [HttpPut("me")]
        public async Task<ActionResult<AddressResponseDTO>> UpdateUserProfile(AppUserResponseDTO model)
        {
            await accountService.UpdateUserProfile(User.GetUserId(), model);
            return Ok();
        }
    }
}
