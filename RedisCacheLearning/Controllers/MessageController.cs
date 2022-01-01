using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RedisCacheLearning.Cache;
using RedisCacheLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisCacheLearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly ApplicationContext _db;
        public MessageController(ApplicationContext db)
        {
            _db = db;
        }
        [HttpPost]
        public IActionResult Createmessage(Message message)
        {
            _db.Messages.Add(message);
            _db.SaveChanges();
            return Ok();
        }
        [HttpGet]
        [Cached(600)]
        public IActionResult GetById(int id)
        {
            return Ok(_db.Messages.Include(x=>x.Info).First(x=>x.Id == id));
        }
    }
}
