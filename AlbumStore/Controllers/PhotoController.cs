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
    public class PhotoController : Controller
    {
        private readonly IDomainManager _domainManager;
        public PhotoController(ILogger<PhotoController> logger, IDomainManager domainManager)
        {
            _domainManager = domainManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetPhotos(int albumId)
        {
            return View("Photo", await _domainManager.GetPhotos(albumId));
        }
    }
}
