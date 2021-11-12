using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Helpers;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class SongRepository : ISongRepository
    {
        private readonly DataContext _context;

        public SongRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<AppSongs> GetSongByIdAsync(int id)
        {
            return await _context.Songs.FindAsync(id);
        }

        public async Task<AppSongs> GetSongBySongNameAsync(string songname)
        {
            //return await _context.Songs.SingleOrDefault(x => x.SongName==songname);
            throw new NotImplementedException();


        }

        public async Task<IEnumerable<AppSongs>> GetSongsAsync()
        {
            return await _context.Songs.ToListAsync();
            //throw new NotImplementedException();

        }

        // public async Task<PagedList<SongDto>> GetMembersAsync(SongParams songParams)
        // {
        //     return await _context.Users 
        //         .ProjectTo<SongDto>(_mapper.ConfigurationProvider)
        //         .ToListAsync();
        //     var query = _context.Users.AsQueryable(); 

        //     return await PagedList<SongDto>.CreateAsync(query.ProjectTo<SongDto>(_mapper
        //         .ConfigurationProvider).AsNoTracking(), 
        //             songParams.PageNumber, songParams.PageSize);
        // }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync()>0;
        }

        public void Update(AppSongs songs)
        {
            _context.Entry(songs).State=EntityState.Modified;
        }
    }
}