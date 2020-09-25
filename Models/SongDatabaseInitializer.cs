using Microsoft.Owin.Security.Provider;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebMusic.Models
{
    public class SongDatabaseInitializer : DropCreateDatabaseAlways<SongContext>
    {
        protected override void Seed(SongContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            //GetSongs().ForEach(p => context.Songs.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Ballad"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Electronic"
                },
                new Category{
                    CategoryID = 3,
                    CategoryName = "Pop"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Rap"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Rock"
                },
            };
            return categories;
        }
    }
}