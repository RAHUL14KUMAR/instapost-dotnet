using instapostBusinesslayer.Service.Interface;
using instapostBusinesslayer.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace instapost.controller
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserSInterface us;
        public UserController(UserSInterface us)
        {
            this.us = us;
        }

        [HttpPost]
        [Route("createUser")]
        public async Task<IActionResult> addUser(UserModel um)
        {
            return null;
        }

        [HttpGet]
        [Route("user/{id}")]
        public async Task<IActionResult> GetUserById(long id)
        {
            return null;
        }

        [HttpPut]
        [Route("user")]
        public async Task<IActionResult> UpdateUser(UserModel um)
        {
            return null;
        }

        public async Task<IActionResult> GetAllUsers()
        {
            return null;
        }
    }
}