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
    [Route("")]
    [Route("[controller]")]
    public class AlbumController : Controller
    {
        private readonly IDomainManager _domainManager;
        public AlbumController(ILogger<AlbumController> logger, IDomainManager domainManager)
        {
            _domainManager = domainManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAlbums()
        {

            return View("Index", await _domainManager.GetAllAlbums());
        }
    }
}
