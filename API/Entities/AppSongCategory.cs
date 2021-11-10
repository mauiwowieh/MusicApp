using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    [Table("AppSongCategories")]
    public class AppSongCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public AppSongs AppSongs { get; set; }
        public int AppSongsId { get; set; }

    }
}