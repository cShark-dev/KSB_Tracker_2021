using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.AspNetCore.Identity;

namespace Domain
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            Files = new Collection<File>();
        }

        public string DisplayName { get; set; }
        public string Bio { get; set; }
        public virtual ICollection<File> Files { get; set; }
        public virtual ICollection<UserApprentices> Apprentices { get; set; }
        public virtual ICollection<RefreshToken> RefreshTokens { get; set; }
    }
}

