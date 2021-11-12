using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class SongUpdateDto
    {
        public string songUrl { get; set; }
        public int songRating { get; set; }
        public bool isFavourite { get; set; }
        
    }
}