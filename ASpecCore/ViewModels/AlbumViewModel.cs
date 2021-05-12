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
            using (NPConDbFirstContext db = new NPConDbFirstContext())
            {
                Albums = new List<album>(db.albums);
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
