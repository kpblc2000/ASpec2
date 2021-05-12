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

            using (NPConEntities db = new NPConEntities())
            {
                Albums = new ObservableCollection<album>(db.albums);
            }
        }

        public ObservableCollection<album> Albums
        {
            get { return _Albums; }
            set { Set(ref _Albums, value); }
        }

        private ObservableCollection<album> _Albums;

    }
}
