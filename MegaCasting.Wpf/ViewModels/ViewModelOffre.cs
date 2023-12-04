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

        private ObservableCollection<MegaCasting.DBLib.Class.Client> _Clients;



        public ViewModelOffre()
        {
            
            using (MegacastingContext mc = new MegacastingContext())
            {
                Clients = new ObservableCollection<MegaCasting.DBLib.Class.Client>(mc.Clients.ToList());
            }
        }

        public ObservableCollection<Client> Clients { get => _Clients; set =>  SetProperty(nameof(Clients), ref _Clients,value); }
    }
}
