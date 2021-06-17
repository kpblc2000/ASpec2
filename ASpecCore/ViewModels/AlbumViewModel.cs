using ASpecCore.Infrastructure;
using ASpecCore.Infrastructure.Commands;
using ASpecCore.Infrastructure.Enums;
using ASpecCore.Models.Data;
using ASpecCore.ViewModels.Base;
using ASpecCore.Views;
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

            _FactoryVM = new FactoryViewModel();

            FilterButtonCommand = new RelayCommand(OnFilterButtonCommandExecuted, CanFilterButtonCommandExecute);
            CreateAlbumCommand = new RelayCommand(OnCreateAlbumCommandExecuted, CanCreateAlbumCommandExecute);
            EditAlbumCommand = new RelayCommand(OnEditAlbumCommandExecuted, CanEditAlbumCommandExecute);
        }

        #region FilterButtonCommand
        public ICommand FilterButtonCommand { get; }

        private void OnFilterButtonCommandExecuted(object p)
        {

            string criteria = p as string;

            if (string.IsNullOrEmpty(criteria) && _FactoryVM.SelectedFactory == null)
            {
                FilteredAlbums = _Albums;
            }
            else if (string.IsNullOrEmpty(criteria) && _FactoryVM.SelectedFactory != null)
            {
                FilteredAlbums = new List<album>(_Albums
                    .Where(o => o.id_fact == _FactoryVM.SelectedFactory.id_fact)
                    );
            }
            else if (!string.IsNullOrEmpty(criteria) && _FactoryVM.SelectedFactory == null)
            {
                string normFilter = criteria.Replace(".", "\\.");
                Regex rx = new Regex($@"(.*){normFilter}(.*)", RegexOptions.IgnoreCase | RegexOptions.Compiled);
                FilteredAlbums = new List<album>(_Albums
                                    .Where(o => rx.Match(o.name_alb).Success
                                               || rx.Match(o.description_alb).Success
                                    ));
            }
            else
            {
                string normFilter = criteria.Replace(".", "\\.");
                Regex rx = new Regex($@"(.*){normFilter}(.*)", RegexOptions.IgnoreCase | RegexOptions.Compiled);
                FilteredAlbums = new List<album>(_Albums
                                    .Where(o => rx.Match(o.name_alb).Success
                                               || rx.Match(o.description_alb).Success
                                               && o.id_fact == _FactoryVM.SelectedFactory.id_fact
                                    ));
            }
            SelectedAlbum = FilteredAlbums.FirstOrDefault();
        }

        private bool CanFilterButtonCommandExecute(object p) => true;
        #endregion

        #region CreateAlbumCommand
        public ICommand CreateAlbumCommand { get; }

        private void OnCreateAlbumCommandExecuted(object p)
        {
            AlbumCreateEditView winAlbEdit = new AlbumCreateEditView();
            AlbumCreateEditViewModel vm = winAlbEdit.DataContext as AlbumCreateEditViewModel;
            vm.Mode = EditMode.CreateMode;
            winAlbEdit.ShowDialog();
            if (winAlbEdit.DialogResult == true)
            {
                using (NPConDataModel db = new NPConDataModel())
                {
                    db.album.Add(vm.ProceedAlbum);
                    db.SaveChanges();
                    _Albums = db.album
                           .Where(o => !o.name_alb.ToUpper().StartsWith("INTERACTIVE")
                           && !o.name_alb.ToUpper().StartsWith("ALLPLAN")
                           && !o.name_alb.StartsWith("allplan")
                           )
                           .OrderBy(o => o.name_alb)
                           .ToList();
                }
                OnFilterButtonCommandExecuted(null);
            }
        }

        private bool CanCreateAlbumCommandExecute(object p)
        {
            return SqlUserRole.IsUserAlbumAdmin;
        }
        #endregion

        #region EditAlbumCommand
        public ICommand EditAlbumCommand { get; }
        private void OnEditAlbumCommandExecuted(object p)
        {
            album copy = new album
            {
                id_album = _SelectedAlbum.id_album,
                description_alb = _SelectedAlbum.description_alb,
                is_end_prod_alb = _SelectedAlbum.is_end_prod_alb,
                in_design = _SelectedAlbum.in_design,
                name_alb = _SelectedAlbum.name_alb
            };
            AlbumCreateEditView winAlbEdit = new AlbumCreateEditView();
            AlbumCreateEditViewModel vm = winAlbEdit.DataContext as AlbumCreateEditViewModel;
            vm.Mode = EditMode.EditMode;
            vm.ProceedAlbum = copy;
            winAlbEdit.ShowDialog();
            if (winAlbEdit.DialogResult == true)
            {
                using (NPConDataModel db = new NPConDataModel())
                {
                    var temp = db.album.Where(o => o.id_album == copy.id_album).FirstOrDefault();
                    temp.in_design = copy.in_design;
                    temp.is_end_prod_alb = copy.is_end_prod_alb;
                    temp.description_alb = copy.description_alb.Trim();
                    temp.name_alb = copy.name_alb.Trim();
                    db.SaveChanges();
                    _Albums = db.album
                            .Where(o => !o.name_alb.ToUpper().StartsWith("INTERACTIVE")
                            && !o.name_alb.ToUpper().StartsWith("ALLPLAN")
                            && !o.name_alb.StartsWith("allplan")
                            )
                            .OrderBy(o => o.name_alb)
                            .ToList();
                }
                OnFilterButtonCommandExecuted(null);
            }
        }
        private bool CanEditAlbumCommandExecute(object p)
        {
            return SqlUserRole.IsUserAlbumAdmin;
        }
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

        public FactoryViewModel FactoryVM
        { get { return _FactoryVM; } }

        public bool CanAccept
        { get { return _SelectedAlbum != null; } }
        #endregion

        private List<album> _Albums;
        private List<album> _FilteredAlbums;
        private album _SelectedAlbum;
        private List<Lines> _FactoryLines;
        private List<factory_lines> _FactoryLineLinks;
        private FactoryViewModel _FactoryVM;
    }
}
