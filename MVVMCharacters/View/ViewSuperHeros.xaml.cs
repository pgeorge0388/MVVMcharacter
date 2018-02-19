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

namespace MVVMCharacters
{
    /// <summary>
    /// Interaction logic for ViewSuperHeros.xaml
    /// </summary>
    public partial class ViewSuperHeros : UserControl
    {
        public ViewSuperHeros()
        {
            InitializeComponent();

            //icHeros.DataContext = new ComicBookViewModel();
            //this.DataContext = new ViewModelOneCharacter();
            this.DataContext = new ComicBookViewModel();
        }

        private void ListBox_Selected(object sender, RoutedEventArgs e)
        {
            string stuff;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string stuff;
        }
            }
}
