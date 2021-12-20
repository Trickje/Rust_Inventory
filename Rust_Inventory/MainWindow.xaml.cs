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
using Rust_Inventory.Code_behind;


namespace Rust_Inventory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private InventoryViewModel m_InventoryViewModel;

        public MainWindow()
        {
            InitializeComponent();
            m_InventoryViewModel = new InventoryViewModel();
            this.DataContext = m_InventoryViewModel;
            this.Show();
        }
        private void OnClick0(object sender, RoutedEventArgs e)
        {
            m_InventoryViewModel.OnClick0();
        }
        private void OnClick1(object sender, RoutedEventArgs e)
        {
            m_InventoryViewModel.OnClick1();
        }
        private void OnClick2(object sender, RoutedEventArgs e)
        {
            m_InventoryViewModel.OnClick2();
        }
        private void OnClick3(object sender, RoutedEventArgs e)
        {
            m_InventoryViewModel.OnClick3();
        }
        private void OnClick4(object sender, RoutedEventArgs e)
        {
            m_InventoryViewModel.OnClick4();
        }
        private void OnClick5(object sender, RoutedEventArgs e)
        {
            m_InventoryViewModel.OnClick5();
        }
        private void OnClick6(object sender, RoutedEventArgs e)
        {
            m_InventoryViewModel.OnClick6();
        }
        private void OnClick7(object sender, RoutedEventArgs e)
        {
            m_InventoryViewModel.OnClick7();
        }
        private void OnClick8(object sender, RoutedEventArgs e)
        {
            m_InventoryViewModel.OnClick8();
        }
        private void OnSwitchStart(object sender, RoutedEventArgs e)
        {
            m_InventoryViewModel.OnSwitchStart();
        }
    }
}
