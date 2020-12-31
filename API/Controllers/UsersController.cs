using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

    public class UsersController : BasApiController
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }


        // public ActionResult<IEnumerable<AppUser>> GetUsers()
        // {
        //     return _context.Usres.ToList();
        // }

        //  [HttpGet("{id}")]
        // public ActionResult<AppUser> GetUser(int id)
        // {
        //     return _context.Usres.Find(id);
        // }

        //async methods 
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await _context.Usres.ToListAsync();
        }
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.Usres.FindAsync(id);
        }
    }
}