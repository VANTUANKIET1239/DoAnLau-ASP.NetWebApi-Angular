using DoAnLau_API.Interface;
using DoAnLau_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DoAnLau_API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountResponsitory _accountResponsitory;

        public AccountController(IAccountResponsitory accountResponsitory)
        {
            this._accountResponsitory = accountResponsitory;
        }
        [HttpPost("SignIn")]
        public async Task<IActionResult> SignIn(SignInModel model)
        {
            var result = await _accountResponsitory.SignIn(model);
            if (string.IsNullOrEmpty(result))
            {
                return BadRequest(result);
            }
            return Ok(new { success = true , token = result });
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(SignUpModel model)
        {
            var result = await _accountResponsitory.SignUp(model);
            if(result.Succeeded)
            {
                return Ok(result.Succeeded);
            }
            return BadRequest();

        }
    }
}
