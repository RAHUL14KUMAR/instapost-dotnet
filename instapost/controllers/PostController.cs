using instapostBusinesslayer.Service.Interface;
using instapostBusinesslayer.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace instapost.controller
{
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly PostSInterface ps;
        public PostController(PostSInterface ps)
        {
            this.ps = ps;
        }

        [HttpPost]
        [Route("createPost/{userId}")]
        public async Task<IActionResult> createPost([FromRoute]long userId,[FromBody] PostReq pm)
        {
            Console.WriteLine("userId " + userId + " postmodel " + pm);
            var res =await ps.CreatePost(userId, pm);
            return Ok(res);
        }

        [HttpGet]
        [Route("post/{id}")]
        public async Task<IActionResult> getPostById(long id)
        {
            return null;
        }

        [HttpPut]
        [Route("post/{userId}")]
        public async Task<IActionResult> updatePost(long userId, [FromBody] long[] ci)
        {
            return null;
        }

        [HttpGet]
        [Route("posts")]
        public async Task<IActionResult> GetAllPosts()
        {
            return null;
        }
    }
}