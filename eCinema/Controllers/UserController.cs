using eCinema.Model;
using eCinema.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eCinema.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            return _userService.GetAllUsers();
        }

        //[HttpGet("{id}")]
        //public User GetById(string id)
        //{
        //    return _userService.GetUserById(id);
        //}
    }
}
