using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Extensions;
using API.Helpers;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class SongController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public SongController(DataContext context, IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppSongs>>> GetSongs(){
            return await _context.Songs.ToListAsync();
            
        }

        //api/songs/3
        [HttpGet("{id}")]
        public async Task<ActionResult<AppSongs>> GetSongs(int id){
            return await _context.Songs.FindAsync(id);
            
        }

        //api/songs/layla
        [HttpGet("{songname}")]
        public async Task<ActionResult<AppSongs>> GetSongs(string SongName){
            return await _context.Songs.FindAsync(SongName);
            
        }

        // [HttpPut]
        // public Task<ActionResult> UpdateSongRequest(SongUpdateDto songUpdateDto){
        //     // var songUrl = Song.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        //     SongDto.songUrl=songUpdateDto.songUrl;
            
        // }

        [HttpPut]
        public async Task<ActionResult> UpdateSong(SongUpdateDto songUpdateDto)
        {
            var songname = _context.Songs.FirstOrDefaultAsync();
            //.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            // _mapper.Map(songUpdateDto, song); 
            //_context.Songs.Update(songUpdateDto);
            var song = _context.Songs.ToList();
            _context.Update(song);
            //if(await _context.SaveChanges()) return NoContent();

            return BadRequest("Failed to update user");

        }

        [HttpDelete("delete-song/{songId}")]
        public async Task<ActionResult> DeleteSong(){
            return NotFound();
        }
    }
}