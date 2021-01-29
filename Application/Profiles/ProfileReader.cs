using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Application.Errors;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Profiles
{
    public class ProfileReader : IProfileReader
    {
        private readonly DataContext _context;
        private readonly IUserAccessor _userAccessor;
        public async Task<Profile> ReadProfile(string username)
        {
            var user = await _context.Users.SingleOrDefaultAsync(x => x.UserName == username);

            if (user == null)
                throw new RestException(HttpStatusCode.NotFound, new { User = "Not found" });

            var currentUser = await _context.Users.SingleOrDefaultAsync(x => x.UserName == _userAccessor.GetCurrentUsername());

            var profile = new Profile
            {
                DisplayName = user.DisplayName,
                Username = user.UserName,
                Bio = user.Bio,
            };

            if (currentUser.Supervisors.Any(x => x.TargetId == user.Id))
            {
                profile.IsFollowed = true;
            }

            return profile;
        }
    }
}