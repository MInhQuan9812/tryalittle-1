using Microsoft.AspNetCore.Identity;
using testdocnet.Models;

namespace testdocnet.Repositories
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> SignUpAsync(SignUpModel model);
        public Task<string> SignInAsync(SignInModel model);

    }
}
