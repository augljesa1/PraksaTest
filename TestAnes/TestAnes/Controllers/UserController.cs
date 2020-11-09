using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAnes.dal.Repositories;
using TestAnes.dal.ViewModel;

namespace TestAnes.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : Controller
    {

        private readonly IUserRepository user;

        public UserController(IUserRepository _user)
        {
            user = _user ?? throw new ArgumentNullException(nameof(_user));
        }

        [HttpGet]
        public async Task<List<UserDto>> GetUsers(int Id)
        {

            var collection = await user.GetUsers(Id);
            return new List<UserDto>(collection.Select(user => new UserDto(user)));

        }
    }
}
