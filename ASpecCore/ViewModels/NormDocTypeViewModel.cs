using ASpecCore.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpecCore.ViewModels
{
    public class NormDocTypeViewModel : ViewModel
    {
        private string _Title;
        public string Title
        { get { return _Title; }
            set
            {
                Set(ref _Title, value);
            }
        }
    }
}
