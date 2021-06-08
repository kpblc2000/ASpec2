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
    public class AlbumViewModel : ViewModel
    {
        public AlbumViewModel()
        {
            Title = "Выберите альбом";
            using (NPConDataModel db = new NPConDataModel())
            {
                _Albums = db.album
                            .Where(o => !o.name_alb.ToUpper().StartsWith("INTERACTIVE")
                            && !o.name_alb.ToUpper().StartsWith("ALLPLAN")
                            && !o.name_alb.StartsWith("allplan")
                            )
                            .OrderBy(o => o.name_alb)
                            .ToList();
                FilteredAlbums = _Albums;
                _Factories = new List<factory>(db.factory);
                _FactoryLines = new List<Lines>(db.Lines);
                _FactoryLineLinks = new List<factory_lines>(db.factory_lines);
                SelectedAlbum = FilteredAlbums[0];
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
            SelectedAlbum = FilteredAlbums.FirstOrDefault();
        }

        private bool CanFilterButtonCommandExecute(object p) => true;
        #endregion

        #region Public properties
        public List<album> FilteredAlbums
        {
            get { return _FilteredAlbums; }
            private set { Set(ref _FilteredAlbums, value); }
        }

        private List<factory> _Factories;

        public album SelectedAlbum
        {
            get { return _SelectedAlbum; }
            set
            {
                if (Set(ref _SelectedAlbum, value))
                {
                    OnPropertyChanged(nameof(CanAccept));
                }
            }
        }

        public bool CanAccept
        { get { return _SelectedAlbum != null; } }
        #endregion

        private List<album> _Albums;
        private List<album> _FilteredAlbums;
        private album _SelectedAlbum;
        private List<Lines> _FactoryLines;
        private List<factory_lines> _FactoryLineLinks;
    }
}
