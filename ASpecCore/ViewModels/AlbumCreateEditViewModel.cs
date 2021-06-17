using ASpecCore.Infrastructure.Enums;
using ASpecCore.Models.Data;
using ASpecCore.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpecCore.ViewModels
{
    public class AlbumCreateEditViewModel : ViewModel
    {
        public AlbumCreateEditViewModel()
        {

        }

        public EditMode Mode
        {
            get { return _Mode; }
            set
            {
                if (Set(ref _Mode, value))
                {
                    if (_Mode == EditMode.EditMode)
                    {
                        Title = "Редактирование альбома";
                    }
                    else if (_Mode == EditMode.CreateMode)
                    {
                        Title = "Новый альбом";
                    }
                    else
                    {
                        Title = "Неопознанный режим";
                    }
                    OnPropertyChanged(nameof(Title));
                }
            }
        }

        public album ProceedAlbum
        {
            get { return _ProceedAlbum; }
            set
            {
                if (Set(ref _ProceedAlbum, value))
                {
                    Name = _ProceedAlbum.name_alb;
                    Description = _ProceedAlbum.description_alb;
                    IsDesignTemAlbum = _ProceedAlbum.in_design == true;
                    IsEndProductAlbum = _ProceedAlbum.is_end_prod_alb == true;
                    OnPropertyChanged(nameof(Name));
                    OnPropertyChanged(nameof(Description));
                    OnPropertyChanged(nameof(IsEndProductAlbum));
                    OnPropertyChanged(nameof(IsDesignTemAlbum));
                }
            }
        }

        public string Name
        {
            get { return _Name; }
            set
            {
                if (Set(ref _Name, value))
                {
                    _ProceedAlbum.name_alb = _Name;
                }
            }
        }

        public string Description
        {
            get { return _Description; }
            set
            {
                if (Set(ref _Description, value))
                {
                    _ProceedAlbum.description_alb = _Description;
                }
            }
        }

        public bool IsEndProductAlbum
        {
            get { return _IsEndProductAlbum; }
            set
            {
                if (Set(ref _IsEndProductAlbum, value))
                {
                    _ProceedAlbum.is_end_prod_alb = _IsEndProductAlbum;
                }
            }
        }

        public bool IsDesignTemAlbum
        {
            get { return _IsDesignTemAlbum; }
            set
            {
                if (Set(ref _IsDesignTemAlbum, value))
                {
                    _ProceedAlbum.in_design = _IsDesignTemAlbum;
                }
            }
        }

        private album _ProceedAlbum;
        private EditMode _Mode;
        private string _Name;
        private string _Description;
        private bool _IsEndProductAlbum;
        private bool _IsDesignTemAlbum;
    }
}
