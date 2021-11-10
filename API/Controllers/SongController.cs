using System;
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
    public class SongController : BaseApiController
    {
        private readonly DataContext _context;
        public SongController(DataContext context) : base(context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<AppSongs>>> GetUsers(){
            return await _context.Songs.ToListAsync();
            
        }

        //api/songs/3
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<AppSongs>> GetUser(int id){
            return await _context.Songs.FindAsync(id);
            
        }
    }
}