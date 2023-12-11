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
    internal class ViewModelClient : ObservableObject
    {

        private ObservableCollection<MegaCasting.DBLib.Class.Client> _Clients;

        private Client? _SelectedClient;

        public ViewModelClient(Client? selectedClient)
        {
            SelectedClient = selectedClient;
        }

        public ViewModelClient()
        {

            using (MegacastingContext mc = new MegacastingContext())
            {
                Clients = new ObservableCollection<MegaCasting.DBLib.Class.Client>(mc.Clients.ToList());
            }
        }

        public ObservableCollection<Client> Clients { get => _Clients; set => SetProperty(nameof(Clients), ref _Clients, value); }
        public Client? SelectedClient { get => _SelectedClient; set => SetProperty(nameof(SelectedClient), ref _SelectedClient, value); }

        internal void RemoveClient()
        {
            if (this.SelectedClient is not null)
            {
                using (MegacastingContext context = new())
                {
                    context.Remove(this.SelectedClient);
                    context.SaveChanges();
                }
                this.Clients?.Remove(this.SelectedClient);
            }
        }
    }
}
