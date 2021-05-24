using ASpecCore.Models.Data;
using ASpecCore.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpecCore.ViewModels
{
    public class SelectAlbumViewModel : ViewModel
    {
        public SelectAlbumViewModel()
        {
            Title = "Выберите альбом";
            using (NPConDataModel db = new NPConDataModel())
            {
                Albums = db.Albums
                            .OrderBy(o => o.name_alb)
                            .ToList();
            }
        }

        public List<album> Albums
        {
            get { return _Albums; }
            private set { Set(ref _Albums, value); }
        }

        public album SelectedAlbum
        {
            get { return _SelectedAlbum; }
            set { Set(ref _SelectedAlbum, value); }
        }

        public bool SelectResult
        {
            get { return _SelectResult; }
            set { Set(ref _SelectResult, value); }
        }

        private List<album> _Albums;
        private album _SelectedAlbum;
        private bool _SelectResult;
    }
}
