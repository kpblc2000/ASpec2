using ASpecCore.Models;
using ASpecCore.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Linq;

namespace ASpecCore.ViewModels
{
    class AlbumTabViewModel : ViewModel
    {
        private Album _SelectedAlbum;
        public Album SelectedAlbum
        {
            get
            {
                return _SelectedAlbum;
            }
            set
            {
                Set(ref _SelectedAlbum, value, nameof(SelectedAlbum));
            }
        }

        private ObservableCollection<Album> _Albums;
        public ObservableCollection<Album> Albums
        {
            get
            {
                return _Albums;
            }
            set
            {
                Set(ref _Albums, value, nameof(Albums));
            }
        }

        public AlbumTabViewModel()
        {
            var albums = Enumerable.Range(1, 20)
                .Select(i => new Album
                {
                    Id = i,
                    Name = $"Альбом {i}",
                    EndProductAlbum = i % 6 == 0,
                    InDesign = i % 7 == 0,
                    Interactive = i % 9 == 0,
                    Description = $"Описание альбома №{i}"
                });
            Albums = new ObservableCollection<Album>(albums);
        }
    }
}
