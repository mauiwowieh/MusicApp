using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
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
        public async Task<ActionResult<IEnumerable<AppSongs>>> GetSongs(){
            return await _context.Songs.ToListAsync();
            
        }

        //api/songs/3
        [HttpGet("{id}")]
        public async Task<ActionResult<AppSongs>> GetSongs(int id){
            return await _context.Songs.FindAsync(id);
            
        }

        // [HttpPut]
        // public Task<ActionResult> UpdateSongRequest(SongUpdateDto songUpdateDto){
        //     // var songUrl = Song.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        //     SongDto.songUrl=songUpdateDto.songUrl;
            
        // }

        [HttpDelete("delete-song/{songId}")]
        public async Task<ActionResult> DeleteSong(){
            return NotFound();
        }
    }
}