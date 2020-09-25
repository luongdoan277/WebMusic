using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebMusic.Models
{
    public class Song
    {
        [ScaffoldColumn(false)]
        public int SongID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string SongName { get; set; }
        [Required, StringLength(10000), Display(Name = "Song Description"),
        DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string AudioPath { get; set; }
        public string ImagePath { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}