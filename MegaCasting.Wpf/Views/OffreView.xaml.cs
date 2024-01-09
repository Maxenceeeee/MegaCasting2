using MegaCasting.Wpf.ViewModels;
using MegaCasting.Wpf.Windows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MegaCasting.Wpf.Views
{
    /// <summary>
    /// Logique d'interaction pour OffreView.xaml
    /// </summary>
    public partial class OffreView : UserControl
    {
        public OffreView()
        {
            InitializeComponent();
            this.DataContext = new ViewModelOffre();
        }

        private void DeleteClientButton_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelOffre)this.DataContext).RemoveClient();
        }

        private void AddClientButton_Click(object sender, RoutedEventArgs e)
        {
            AddClientView? window = new();
            window.ShowDialog();
            ((ViewModelOffre)this.DataContext).Refresh();
        }
    }
}
