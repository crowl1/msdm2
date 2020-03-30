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

namespace msdm2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public  NameOrder;
        public MainWindow()
        {
            InitializeComponent();
            Containers.main.filling_list();

            //Прив'язка імені
            Binding binding = new Binding();
            binding.ElementName = "Name";
            binding.Path = new PropertyPath("Text");
            Name.SetBinding(TextBlock.TextProperty, binding);

            //Прив'язка списків
            comboBox_goods.ItemsSource = Containers.main.goodss.Name;
        }
    }
    class Containers
    {
        public static ViewModel.IDelivery main { get; set; } = new ViewModel.Delivery();
    }
}
