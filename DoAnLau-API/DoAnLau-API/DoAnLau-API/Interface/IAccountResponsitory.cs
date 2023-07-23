using DoAnLau_API.Models;
using Microsoft.AspNetCore.Identity;

namespace DoAnLau_API.Interface
{
    public interface IAccountResponsitory
    {
        public Task<IdentityResult> SignUp(SignUpModel model);
        
        public Task<string> SignIn(SignInModel model);
    }
}
