using Api.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UsersController : ControllerBase
    {
        private readonly Datacontext _dataContext;
        public UsersController(Datacontext datacontext)
        {
            _dataContext = datacontext;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUSers ()
        {
            return await _dataContext.appUsers.ToListAsync();

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUSer(int id)
        {
            return await _dataContext.appUsers.FindAsync(id);

        }
    }
}
