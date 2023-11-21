using MegaCasting.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCasting.DBLib.Class;

namespace MegaCasting.Wpf.ViewModels
{
    internal class ViewModelOffre : ObservableObject
    {

        private ObservableCollection<MegaCasting.DBLib.Class.Offrecasting> _Offres;



        public ViewModelOffre()
        {
            
            using (MegacastingContext mc = new MegacastingContext())
            {
                Offres = new ObservableCollection<Offrecasting>(mc.Offrecastings.ToList());
            }
        }

        public ObservableCollection<Offrecasting> Offres { get => _Offres; set =>  SetProperty(nameof(Offres), ref _Offres,value); }
    }
}
