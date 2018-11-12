using System.Collections.Generic;
using System.Linq;
using MentalHealthTracker.Api.Models;
using MentalHealthTracker.Domain;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Http;

namespace MentalHealthTracker.Api.Controllers
{
    [Route("api/v1/users")]
    public class UserController : ApiController
    {
        private MentalContext _mentalHealthContext;

        public UserController()
        {
            _mentalHealthContext = new MentalContext();
        }

        public async Task<ICollection<UserModel>> GetAllUsers()
        {
            var users = await _mentalHealthContext.Users.Select(x => new UserModel
            {
                UserId = x.UserId,
                Email = x.Email,
                Password = x.Password,
                FirstName = x.FirstName,
                LastName = x.LastName
            }).ToListAsync();

            return users;
        }
    }
}