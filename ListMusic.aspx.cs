using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMusic.Models;

namespace WebMusic
{
    public partial class ListMusic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Song> GetSongs([QueryString("id")] int? categoryId)
        {
            var _db = new WebMusic.Models.SongContext();
            IQueryable<Song> query = _db.Songs;
            if (categoryId.HasValue && categoryId > 0)

            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            return query;
        }
    }
}