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

namespace DynamicStruct
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Stack<Monitor> monitors;
        public MainWindow()
        {
            InitializeComponent();
            monitors = new Stack<Monitor>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddEditWindow add = new AddEditWindow();
            if(add.ShowDialog()==true)
            {
                string name = add.NameMonitor;
                float diag = add.DiagMonitor;
                decimal pr = add.PriceMonitor;
                Monitor monitor = new Monitor(name,diag,pr);
                monitors.Push(monitor);
                UpdateStack();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            monitors.Pop();
            UpdateStack();
        }
        private void UpdateStack()
        {
            StackPanel.ItemsSource = null;
            StackPanel.Items.Clear();
            StackPanel.ItemsSource = monitors;
        }
    }
}
