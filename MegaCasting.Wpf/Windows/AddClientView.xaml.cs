using MegaCasting.Wpf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MegaCasting.Wpf.Windows
{
    /// <summary>
    /// Logique d'interaction pour AddClientView.xaml
    /// </summary>
    public partial class AddClientView : Window
    {
        public AddClientView()
        {
            InitializeComponent();
            this.DataContext = new AjouterClientViewModel();
        }

        private void AddClientButton_Click(object sender, RoutedEventArgs e)
        {
            ((AjouterClientViewModel)this.DataContext).AddClient();
            this.Close();
        }

        private void UpdateClientButton_Click(object sender, RoutedEventArgs e)
        {
            ((AjouterClientViewModel)this.DataContext).AddClient();
            this.Close();
        }
    }
}
