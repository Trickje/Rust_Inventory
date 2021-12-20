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
        private ItemViewModel m_ViewModel;

        public MainWindow()
        {
            InitializeComponent();
            m_ViewModel = new ItemViewModel();
            this.DataContext = m_ViewModel;
            this.Show();
        }
        private void OnClick0(object sender, RoutedEventArgs e)
        {
            if (m_ViewModel.Switching)
            {
                m_ViewModel.SwapItems(m_ViewModel.SelectedInventorySlot, 0);
            }
            m_ViewModel.UpdateCurrentSelection(0);
        }
        private void OnClick1(object sender, RoutedEventArgs e)
        {
            if (m_ViewModel.Switching)
            {
                m_ViewModel.SwapItems(m_ViewModel.SelectedInventorySlot, 1);
            }
            m_ViewModel.UpdateCurrentSelection(1);
        }
        private void OnClick2(object sender, RoutedEventArgs e)
        {
            if (m_ViewModel.Switching)
            {
                m_ViewModel.SwapItems(m_ViewModel.SelectedInventorySlot, 2);
            }
            m_ViewModel.UpdateCurrentSelection(2);
        }
        private void OnClick3(object sender, RoutedEventArgs e)
        {
            if (m_ViewModel.Switching)
            {
                m_ViewModel.SwapItems(m_ViewModel.SelectedInventorySlot, 3);
            }
            m_ViewModel.UpdateCurrentSelection(3);
        }
        private void OnClick4(object sender, RoutedEventArgs e)
        {
            if (m_ViewModel.Switching)
            {
                m_ViewModel.SwapItems(m_ViewModel.SelectedInventorySlot, 4);
            }
            m_ViewModel.UpdateCurrentSelection(4);
        }
        private void OnClick5(object sender, RoutedEventArgs e)
        {
            if (m_ViewModel.Switching)
            {
                m_ViewModel.SwapItems(m_ViewModel.SelectedInventorySlot, 5);
            }
            m_ViewModel.UpdateCurrentSelection(5);
        }
        private void OnClick6(object sender, RoutedEventArgs e)
        {
            if (m_ViewModel.Switching)
            {
                m_ViewModel.SwapItems(m_ViewModel.SelectedInventorySlot, 6);
            }
            m_ViewModel.UpdateCurrentSelection(6);
        }
        private void OnClick7(object sender, RoutedEventArgs e)
        {
            if (m_ViewModel.Switching)
            {
                m_ViewModel.SwapItems(m_ViewModel.SelectedInventorySlot, 7);
            }
            m_ViewModel.UpdateCurrentSelection(7);
        }
        private void OnClick8(object sender, RoutedEventArgs e)
        {
            if (m_ViewModel.Switching)
            {
                m_ViewModel.SwapItems(m_ViewModel.SelectedInventorySlot, 8);
            }
            m_ViewModel.UpdateCurrentSelection(8);
        }
        private void OnSwitchStart(object sender, RoutedEventArgs e)
        {
            m_ViewModel.Switching = !m_ViewModel.Switching;
        }
    }
}
