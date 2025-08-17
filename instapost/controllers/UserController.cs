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
            var data = await us.CreateUser(um);
            return Ok(data);
        }

        [HttpGet]
        [Route("user/{id}")]
        public async Task<IActionResult> GetUserById(long id)
        {
            var data = await us.GetUserById(id);
            return Ok(data);
        }

        [HttpPut]
        [Route("user/{userId}")]
        public async Task<IActionResult> UpdateUser(long userId,[FromBody] long[] cI)
        {
            Console.WriteLine("ci -> " + string.Join(",", cI));
            var data = await us.UpdateUser(userId,cI);
            return Ok(data);
        }

        [HttpGet]
        [Route("users")]
        public async Task<IActionResult> GetAllUsers()
        {
            var data = await us.GetAllUsers();
            return Ok(data);
        }
    }
}