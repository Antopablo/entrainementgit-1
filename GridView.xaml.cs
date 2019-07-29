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

namespace Entrainementgit
{
    /// <summary>
    /// Logique d'interaction pour GridView.xaml
    /// </summary>
    public partial class GridView : Window
    {
        public GridView()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            Close();
        }
    }
}
