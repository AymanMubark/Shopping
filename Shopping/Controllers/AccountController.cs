using Microsoft.AspNetCore.Mvc;
using Shopping.DTOs;
using Shopping.IServices;
using Shopping.Models;

namespace Shopping.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly IAccountService accountService;

        public AccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        [HttpPost("Login")]
        public async Task<ActionResult<LoginResponseDTO>> Login(LoginRequestDTO model)
        {
            return await accountService.Login(model.UserName, model.Password);
        }

        [HttpPost("Register")]
        public async Task<ActionResult<LoginResponseDTO>> Register(RegisterRequestDTO model)
        {
            return Ok(await accountService.Register(model));
        }

        [HttpGet("check")]
        public  IActionResult check()
        {
            return Ok("ds");
        }

    }
}
