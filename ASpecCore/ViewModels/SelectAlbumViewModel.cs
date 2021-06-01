using ASpecCore.Infrastructure.Commands;
using ASpecCore.Models.Data;
using ASpecCore.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ASpecCore.ViewModels
{
    public class SelectAlbumViewModel : ViewModel
    {
        public SelectAlbumViewModel()
        {
            Title = "Выберите альбом";
            using (NPConDataModel db = new NPConDataModel())
            {
                _Albums = db.albums
                            .Where(o => !o.name_alb.ToUpper().StartsWith("INTERACTIVE")
                            && !o.name_alb.ToUpper().StartsWith("ALLPLAN")
                            && !o.name_alb.StartsWith("allplan")
                            )
                            .OrderBy(o => o.name_alb)
                            .ToList();
                FilteredAlbums = _Albums;
            }

            FilterButtonCommand = new RelayCommand(OnFilterButtonCommandExecuted, CanFilterButtonCommandExecute);
        }

        #region FilterButtonCommand
        public ICommand FilterButtonCommand { get; }

        private void OnFilterButtonCommandExecuted(object p)
        {

            string criteria = p as string;

            if (string.IsNullOrEmpty(criteria))
            {
                FilteredAlbums = _Albums;
            }
            else
            {
                string normFilter = criteria.Replace(".", "\\.");
                Regex rx = new Regex($@"(.*){normFilter}(.*)", RegexOptions.IgnoreCase | RegexOptions.Compiled);
                FilteredAlbums = _Albums
                                    .Where(o => rx.Match(o.name_alb).Success
                                               || rx.Match(o.description_alb).Success
                                    )
                                    .ToList();
            }
            if (FilteredAlbums.Count > 0)
            {
                SelectedAlbum = FilteredAlbums[0];
            }

        }

        private bool CanFilterButtonCommandExecute(object p) => true;
        #endregion

        #region Public properties
        public List<album> FilteredAlbums
        {
            get { return _FilteredAlbums; }
            set { Set(ref _FilteredAlbums, value); }
        }

        public album SelectedAlbum
        {
            get { return _SelectedAlbum; }
            set { Set(ref _SelectedAlbum, value); }
        }
        #endregion

        private List<album> _Albums;
        private List<album> _FilteredAlbums;
        private album _SelectedAlbum;
    }
}
