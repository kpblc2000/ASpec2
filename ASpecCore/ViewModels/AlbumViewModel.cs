using ASpecCore.Models.Data;
using ASpecCore.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpecCore.ViewModels
{
    public class AlbumViewModel : ViewModel
    {
        public AlbumViewModel()
        {
            Title = "Альбомы";
            using (Entities db = new Entities())
            {
                Albums = db.albums.ToList();
            }
        }

        public List<album> Albums
        {
            get { return _Albums; }
            set { Set(ref _Albums, value); }
        }


        private List<album> _Albums;

    }
}
