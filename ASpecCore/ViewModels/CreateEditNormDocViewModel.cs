using ASpecCore.Infrastructure;
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
        public CreateEditNormDocViewModel()
        {
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

                    normdoc newDoc = new normdoc
                    {
                        description = DocDescription?.Trim(),
                        doccode = DocNum?.Trim(),
                        doctype = DocType?.Trim()
                    };

                    db.normdoc.Add(newDoc);
                    db.SaveChanges();
                    _NeedUpdate = true;
                    DocList.Add(newDoc);
                }
                else
                {
                    normdoc curDoc = db.normdoc.Where(o => o.id_normdoc == DocToEdit.id_normdoc).FirstOrDefault();

                    if (curDoc != null)
                    {
                        curDoc.description = DocDescription?.Trim();
                        curDoc.doccode = DocNum?.Trim();
                        curDoc.doctype = DocType?.Trim();
                        db.SaveChanges();

                        normdoc listDoc = DocList.Where(o => o.id_normdoc == DocToEdit.id_normdoc).FirstOrDefault();

                        listDoc.description = DocDescription?.Trim();
                        listDoc.doccode = DocNum?.Trim();
                        listDoc.doctype = DocType?.Trim();

                        _NeedUpdate = true;
                    }
                }
            }
        }

        public bool CanSaveNormDocCommandExecute(object p)
        {
            return !SqlUserRole.IsUserReadOnly
                && !string.IsNullOrEmpty(DocType)
                && !string.IsNullOrEmpty(DocNum)
                && !string.IsNullOrEmpty(DocDescription)
                && DocList.FirstOrDefault(o =>
                                            o.doctype.Trim() == DocType.Trim()
                                            && o.doccode.Trim() == DocNum.Trim()
                                            && o.description.Trim() == DocDescription.Trim()
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
            set { Set(ref _DocType, value.ToUpper()); }
        }
        public string DocNum
        {
            get => _DocNum;
            set { Set(ref _DocNum, value); }
        }

        public string DocDescription
        {
            get => _DocDescription;
            set { Set(ref _DocDescription, value); }
        }

        public List<normdoc> DocList
        {
            get { return _DocList; }
            set { Set(ref _DocList, value); }
        }

        public normdoc DocToEdit
        {
            get { return _DocToEdit; }
            set
            {
                if (Set(ref _DocToEdit, value))
                {
                    DocDescription = _DocToEdit.description;
                    DocType = _DocToEdit.doccode;
                    DocNum = _DocToEdit.doctype;
                }
            }
        }

        public bool NeedUpdate
        { get { return _NeedUpdate; } }

        #endregion

        private EditMode _CurrentMode;
        private string _DocType;
        private List<normdoc> _DocList;
        private string _DocNum;
        private string _DocDescription;
        private normdoc _DocToEdit;
        private bool _NeedUpdate;
    }
}
