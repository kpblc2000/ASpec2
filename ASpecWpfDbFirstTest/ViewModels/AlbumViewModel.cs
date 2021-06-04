using ASpecWpfDbFirstTest.Data;
using ASpecWpfDbFirstTest.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpecWpfDbFirstTest.ViewModels
{
    public class AlbumViewModel : ViewModel
    {
        public AlbumViewModel()
        {
            Title = "Альбомы";
            using (NPConConnectionString db = new NPConConnectionString())
            {
                Albums = new ObservableCollection<album>(from o in db.album
                                                         where o.factory!= null
                                                         select o
                                                         );
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
