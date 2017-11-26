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

namespace wpfLibreria
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void manGenero_Click(object sender, RoutedEventArgs e)
        {
            MainContainerMdi.Children.Add(new WPF.MDI.MdiChild() {
                Title = "Hola uqe hace",
                Content = new Mantenimientos.Generos()

            });

        }
    }
}
