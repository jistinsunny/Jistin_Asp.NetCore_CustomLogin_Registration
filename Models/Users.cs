using Microsoft.AspNetCore.Identity;

namespace Dev_JS_LoginForm.Models
{
    public class Users : IdentityUser
    {

        public string FullName { get; set; }
    }
}
