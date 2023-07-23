using DoAnLau_API.Data;
using DoAnLau_API.FF;
using DoAnLau_API.Interface;
using DoAnLau_API.Models;
using Microsoft.AspNetCore.Identity;

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
        public Task<string> SignIn()
        {
            return null;
        }

        public async Task<IdentityResult> SignUp(SignUpModel model)
        {
            var user = new ApplicationUser
            {
                name = model.name,
                Email = model.email,
                UserName = model.name,
                userImage = OtherFunctions.PathImage2Byte("C:\\Users\\PC\\Desktop\\DoAn-Lau\\DoAnLau-API\\DoAnLau-API\\DoAnLau-API\\Image\\default_user.jpg"),
                birthdate = model.birthdate,
                gender = model.gender,
                rewardPoints = 0
            };
            return await _userManager.CreateAsync(user);
        }

    }
}
