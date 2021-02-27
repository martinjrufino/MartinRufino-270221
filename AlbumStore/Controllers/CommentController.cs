using MartinJRufino_20210227.Manager.Interfaces;
using MartinJRufino_20210227.Model.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MartinJRufino_20210227.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentController : Controller
    {
        private readonly IDomainManager _domainManager;
        public CommentController(ILogger<CommentController> logger, IDomainManager domainManager)
        {
            _domainManager = domainManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetComments(int postId)
        {
            return View("Comment", await _domainManager.GetComments(postId));
        }
    }
}
