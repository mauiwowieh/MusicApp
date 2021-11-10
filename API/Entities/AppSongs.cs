using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppSongs
    {
        public int Id { get; set; }
        public string SongName { get; set; }
        public string ArtistName { get; set; }
        public string SongUrl { get; set; }
        public int SongRating { get; set; }
        public bool IsFavourite { get; set; }
        public DateTime SongEntered { get; set; }
        public DateTime SongEdited { get; set; }
        public ICollection<AppSongCategory> SongCategory { get; set; }
    }
}