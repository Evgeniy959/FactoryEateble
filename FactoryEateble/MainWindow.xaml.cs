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

namespace FactoryEateble
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            object something = null;
            Factory factory = new Factory();
            if (rb1.IsChecked == true)
                something = factory.GetEateble(1);
            if (rb2.IsChecked == true)
                something = factory.GetEateble(2);
            if (rb3.IsChecked == true)
                something = factory.GetEateble(3);
            if (rb4.IsChecked == true)
                something = factory.GetEateble(4);
            if(something is IceCream ice) 
            MessageBox.Show(ice.Eat());
            if (something is Chocolate cho)
                MessageBox.Show(cho.Eat());
        }
    }
}
