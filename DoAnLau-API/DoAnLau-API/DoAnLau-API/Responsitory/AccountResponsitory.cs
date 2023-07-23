using DoAnLau_API.Data;
using DoAnLau_API.FF;
using DoAnLau_API.Interface;
using DoAnLau_API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DoAnLau_API.Responsitory
{
    public class AccountResponsitory : IAccountResponsitory
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;

        public AccountResponsitory(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._configuration = configuration;
        }
        public async Task<string> SignIn(SignInModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.email, model.password,false,false);

            if (!result.Succeeded) {
                return string.Empty;
            }

            // tạo claim 
            var authClaims = new List<Claim>()
            {
                new Claim(ClaimTypes.Email, model.email),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };
            // tao khóa
            var authenKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            // tạo Token

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddMinutes(40),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authenKey, SecurityAlgorithms.HmacSha512Signature)
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<IdentityResult> SignUp(SignUpModel model)
        {
            var user = new ApplicationUser
            {
                name = model.name,
                Email = model.email,
                UserName = model.email,
                userImage = OtherFunctions.PathImage2Byte("C:\\Users\\PC\\Desktop\\DoAn-Lau\\DoAnLau-API\\DoAnLau-API\\DoAnLau-API\\Image\\default_user.jpg"),
                birthdate = model.birthdate,
                gender = model.gender,
                rewardPoints = 0
            };
            return await _userManager.CreateAsync(user,model.password);
        }

    }
}
