using ASpecCore.Models.Data;
using ASpecCore.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
                _Factories = new List<factory>(db.factories);
                Albums = new List<album>(db.albums);
            }
        }

        public album SelectedAlbum
        {
            get { return _SelectedAlbum; }
            set { Set(ref _SelectedAlbum, value); }
        }

        public List<album> Albums
        {
            get { return _Albums; }
            private set { Set(ref _Albums, value); }
        }

        private List<album> _Albums;
        private readonly List<factory> _Factories;
        private album _SelectedAlbum;
    }
}
