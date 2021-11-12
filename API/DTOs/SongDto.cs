using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class SongDto
    {
        public int Id { get; set; }
        public string songName { get; set; }
        public string artistName { get; set; }
        public string songUrl { get; set; }
        public int songRating { get; set; }
        public bool isFavourite { get; set; }
        public DateTime songEntered { get; set; }
        public DateTime songEdited { get; set; }
        public string songCategory { get; set; }
  
    }
}