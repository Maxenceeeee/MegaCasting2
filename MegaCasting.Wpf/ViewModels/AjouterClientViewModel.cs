using MegaCasting.Core;
using MegaCasting.DBLib.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.Wpf.ViewModels
{
    class AjouterClientViewModel : ObservableObject
    {
        private Client _Client;

        public Client Client { get => _Client; set => _Client = value; }

        public AjouterClientViewModel()
        {
            Client = new Client();
        }


        internal void AddClient()
        {

            using (MegacastingContext context = new())
            {
                context.Add(Client);
                context.SaveChanges();
            }
        }
    }
}
