using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Helpers;


namespace API.Interfaces
{
    public interface ISongRepository
    {
        void Update(AppSongs user);
        Task<IEnumerable<AppSongs>> GetSongsAsync();
        Task<AppSongs> GetSongByIdAsync(int id);
        Task<AppSongs> GetSongBySongNameAsync(string songname);
        Task<bool> SaveAllAsync();
    }
}