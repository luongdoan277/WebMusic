﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;


namespace WebMusic.Models
{
    public class Category
    {
        [ScaffoldColumn(false)]
        public int CategoryID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string CategoryName { get; set; }
        [Display(Name = "Product Description")]
        public string Description { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}