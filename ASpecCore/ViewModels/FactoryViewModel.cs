using ASpecCore.Models.Data;
using ASpecCore.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpecCore.ViewModels
{
    public class FactoryViewModel : ViewModel
    {
        public FactoryViewModel()
        {
            Title = "Заводы";

            using (NPConDataModel db = new NPConDataModel())
            {
                Factories = new List<factory>(db.factories);
            }
        }

        public List<factory> Factories
        {
            get { return _Factories; }
            set { Set(ref _Factories, value); }
        }

        public factory GetFactoryById(int? Id)
        {
            if (Id != null)
            {
                return _Factories.Where(o => o.id_fact == Id).FirstOrDefault();
            }
            else
            {
                return null;
            }

        }

        private List<factory> _Factories;
    }
}
