using ASpecCore.Models.Data;
using ASpecCore.ViewModels.Base;
using System.Collections.Generic;

namespace ASpecCore.ViewModels
{
    public class AlbumViewModel : ViewModel
    {
        public AlbumViewModel()
        {
            Title = "Альбомы";
            using (NPConDbFirstContext db = new NPConDbFirstContext())
            {
                _Factories = new List<factory>(db.factories);
                Albums = new List<album>(db.albums);
            }
        }

        public List<album> Albums
        {
            get { return _Albums; }
            set { Set(ref _Albums, value); }
        }

        private List<album> _Albums;
        private readonly List<factory> _Factories;
    }
}
