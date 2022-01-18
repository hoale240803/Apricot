using Apricot.API.Services;
using Apricot.Domain.Aggregate.Blog;
using Microsoft.AspNetCore.Mvc;

namespace Apricot.API.Controllers
{
    [Route("api/blogs")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        public readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        /// <summary>
        /// create new blog
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost]
        public async Task<IActionResult> AddBlog([FromBody] Blog blog)
        {
            var result = await _blogService.AddBlogAsync(blog);

            return Ok(result);
        }

        /// <summary>
        /// get all blogs
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpGet]
        public async Task<IActionResult> GetBlogsAsync()
        {
            var result = await _blogService.GetBlogs();

            return Ok(result);
        }

        /// <summary>
        /// update a blog
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        ///
        [HttpPut]
        public async Task<IActionResult> UpdateBlog([FromBody] Blog blog)
        {
            var result = await _blogService.UpdateBlog(blog);

            return Ok(result);
        }
    }
}