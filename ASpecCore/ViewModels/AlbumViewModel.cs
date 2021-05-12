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
                _Albums = new List<album>(db.albums);
                ShownAlbums = _Albums;
            }
        }

        public List<album> ShownAlbums
        {
            get { return _ShownAlbums; }
            set { Set(ref _ShownAlbums, value); }
        }

        public bool? ShowOnlyEndProductAlbums
        {
            get { return _ShowOnlyEndProductAlbums; }
            set
            {
                if (Set(ref _ShowOnlyEndProductAlbums, value))
                {
                    if (value == null)
                    {
                        ShownAlbums = _Albums;
                    }
                    else
                    {
                        ShownAlbums = new List<album>(_Albums.Where(o => o.is_end_prod_alb == value));
                    }
                }
            }
        }

        public bool? ShowOnlyFactoryAlbums
        {
            get { return _ShowOnlyFactoryAlbums; }
            set
            {
                if (Set(ref _ShowOnlyFactoryAlbums, value))
                {
                    if (value == null)
                    {
                        ShownAlbums = _Albums;
                    }
                    else if (value == true)
                    {
                        ShownAlbums = new List<album>(_Albums.Where(o => o.factory != null));
                    }
                    else
                    {
                        ShownAlbums = new List<album>(_Albums.Where(o => o.factory == null));
                    }
                }
            }
        }

        private void RefillShownAlbums()
        {
            List<album> resList = new List<album>();
            if (_ShowOnlyEndProductAlbums == null && _ShowOnlyFactoryAlbums == null)
            {
                resList = _Albums;
            }
            else if (_ShowOnlyEndProductAlbums != null && _ShowOnlyFactoryAlbums == null)
            {
                foreach (album item in _Albums.Where(o => o.is_end_prod_alb == _ShowOnlyEndProductAlbums))
                {
                    resList.Add(item);
                }
            }
            else if (_ShowOnlyEndProductAlbums != null && _ShowOnlyFactoryAlbums == true)
            {
                foreach (var item in _Albums.Where(o => o.is_end_prod_alb == _ShowOnlyEndProductAlbums && o.id_fact != null))
                {
                    resList.Add(item);
                }
            }
            else if (_ShowOnlyEndProductAlbums != null && _ShowOnlyFactoryAlbums == false)
            {
                foreach (var item in _Albums.Where(o => o.is_end_prod_alb == _ShowOnlyEndProductAlbums && o.id_fact == null))
                {
                    resList.Add(item);
                }
            }
            if (resList.Count==0)
            {
                ShownAlbums = new List<album>();
            }
            else
            {
                ShownAlbums = resList;
            }
        }

        private List<album> _Albums;
        private List<album> _ShownAlbums;

        private bool? _ShowOnlyEndProductAlbums;
        private bool? _ShowOnlyFactoryAlbums;

    }
}
