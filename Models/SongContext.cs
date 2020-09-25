using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebMusic.Models
{
    public class SongContext : DbContext
    {
        public SongContext() : base("Music")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}