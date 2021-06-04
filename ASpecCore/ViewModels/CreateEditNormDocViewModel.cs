using ASpecCore.Infrastructure.Commands;
using ASpecCore.Infrastructure.Enums;
using ASpecCore.Models.Data;
using ASpecCore.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ASpecCore.ViewModels
{
    public class CreateEditNormDocViewModel : ViewModel
    {
        public CreateEditNormDocViewModel() : this(null, null, EditMode.UnKnownMode) { }

        public CreateEditNormDocViewModel(List<normdoc> NormDocList, normdoc NormDocToEdit, EditMode DialogMode)
        {
            DocList = NormDocList;
            DocToEdit = NormDocToEdit;
            CurrentMode = DialogMode;
            SaveNormDocCommand = new RelayCommand(OnSaveNormDocCommandExecuted, CanSaveNormDocCommandExecute);

        }

        #region Commands
        #region SaveNormDocCommand
        public ICommand SaveNormDocCommand { get; }

        private void OnSaveNormDocCommandExecuted(object p)
        {
            using (NPConDataModel db = new NPConDataModel())
            {
                if (CurrentMode == EditMode.CreateMode)
                {
                    db.normdocs.Add(new normdoc
                    {
                        description = DocDescription,
                        doccode = DocNum,
                        doctype = DocType
                    }
                    );
                    db.SaveChanges();
                }
                else
                {
                    DocToEdit.description = DocDescription;
                    DocToEdit.doccode = DocNum;
                    DocToEdit.doctype = DocType;
                    db.SaveChanges();
                }
            }
        }

        public bool CanSaveNormDocCommandExecute(object p)
        {
            return !string.IsNullOrEmpty(DocType)
                && !string.IsNullOrEmpty(DocNum)
                && !string.IsNullOrEmpty(DocDescription)
                && DocList.FirstOrDefault(o =>
                                            o.doctype == DocType
                                            && o.doccode == DocNum
                                            ) == null;
        }
        #endregion
        #endregion

        #region Public properties
        public EditMode CurrentMode
        {
            get { return _CurrentMode; }
            set
            {
                if (Set(ref _CurrentMode, value))
                {
                    if (_CurrentMode == EditMode.EditMode)
                    {
                        Title = "Редактирование норм.документа";
                    }
                    else
                    {
                        Title = "Добавление норм.документа";
                    }
                }
            }
        }

        public string DocType
        {
            get { return _DocType; }
            set { Set(ref _DocType, value.Trim()); }
        }
        public string DocNum { get => _DocNum; set => Set(ref _DocNum, value.Trim()); }

        public string DocDescription { get => _DocDescription; set => Set(ref _DocDescription, value.Trim()); }

        public List<normdoc> DocList
        {
            get { return _DocList; }
            set { Set(ref _DocList, value); }
        }

        public normdoc DocToEdit
        {
            get { return _DocToEdit; }
            set { Set(ref _DocToEdit, value); }
        }
        #endregion

        private EditMode _CurrentMode;
        private string _DocType;
        private List<normdoc> _DocList;
        private string _DocNum;
        private string _DocDescription;
        private normdoc _DocToEdit;
    }
}
