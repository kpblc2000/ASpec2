using ASpecCore.Models.Data;
using ASpecCore.ViewModels.Base;
using System.Collections.Generic;

namespace ASpecCore.ViewModels
{
    public class FactoryViewModel : ViewModel
    {
        public FactoryViewModel()
        {
            Title = "Заводы";

            using (NPConDbFirstContext db = new NPConDbFirstContext())
            {
                Factories = new List<factory>(db.factories);
            }
        }

        public List<factory> Factories
        {
            get { return _Factories; }
            set { Set(ref _Factories, value); }
        }

        private List<factory> _Factories;
    }
}
