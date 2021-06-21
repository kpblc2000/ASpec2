using ASpecCore.Infrastructure.Enums;
using ASpecCore.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpecCore.ViewModels
{
    public class ArmatureCreateEditViewModel : ViewModel
    {
        public ArmatureCreateEditViewModel()
        {
            NormDocVM = new NormDocViewModel();
        }

        public NormDocViewModel NormDocVM
        { get { return _NormDocVM;  }
            private set { Set(ref _NormDocVM, value); }
        }

        public EditMode CurrentMode
        {
            get { return _CurrentMode; }
            set
            {
                if (Set(ref _CurrentMode, value))
                {
                    if (_CurrentMode == EditMode.EditMode)
                    {
                        Title = "Редактирование арматуры";
                    }
                    else if (_CurrentMode == EditMode.CreateMode)
                    {
                        Title = "Добавление арматуры";
                    }
                    else
                    {
                        Title = "Неизвестный режим";
                    }
                    OnPropertyChanged(nameof(Title));
                }
            }
        }

        private NormDocViewModel _NormDocVM;
        private EditMode _CurrentMode;
    }
}
