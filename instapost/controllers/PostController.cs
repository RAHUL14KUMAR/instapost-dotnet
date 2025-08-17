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
        [Route("createPost")]
        public async Task<IActionResult> createPost(PostModel pm)
        {
            return null;
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