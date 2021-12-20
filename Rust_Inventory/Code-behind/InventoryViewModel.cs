using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Rust_Inventory.Code_behind
{
    class InventoryViewModel : INotifyPropertyChanged
    {
        private Inventory m_Inventory;
        public int SelectedInventorySlot;
        private bool m_Switching;
        public IList<ItemViewModel> Items {
            get
            {
               return m_Inventory.ItemsVM;
            }
            private set
            {

            }
        }
        public InventoryViewModel()
        {
            m_Inventory = new Inventory();
            SelectedInventorySlot = 0;
            Switching = false;
            SwitchString = "Not Swapping";


            m_CurrentSelectedItem = m_Inventory.ItemsVM[SelectedInventorySlot];
        }

        public bool Switching
        {
            get
            {
                return m_Switching;
            }
            set
            {
                if (value == false)
                {
                    m_SwitchString = "Not swapping";
                    OnPropertyChanged("SwitchString");
                }
                else
                {
                    m_SwitchString = "Swapping items";
                    OnPropertyChanged("SwitchString");
                }
                m_Switching = value;
            }
        }
        private string m_SwitchString;
        public string SwitchString
        {
            get
            {
                return m_SwitchString;
            }
            set
            {
                m_SwitchString = value;
            }
        }

        private ItemViewModel m_CurrentSelectedItem;
        public ItemViewModel CurrentSelectedItem
        {
            get
            {
                return m_CurrentSelectedItem;
            }
            set
            {
                m_CurrentSelectedItem = value;
            }
        }
        public void UpdateCurrentSelection(int index)
        {
            SelectedInventorySlot = index;
            m_CurrentSelectedItem = m_Inventory.ItemsVM[SelectedInventorySlot];
            OnPropertyChanged("CurrentSelectedItem");

        }

        public void OnClick0()
        {
            if (Switching)
            {
                if(m_Inventory.SwapItems(SelectedInventorySlot, 0))
                {
                    OnPropertyChanged("Items");
                    Switching = false;
                }
            }
            UpdateCurrentSelection(0);
        }
        public void OnClick1()
        {
            if (Switching)
            {
                if (m_Inventory.SwapItems(SelectedInventorySlot, 1))
                {
                    OnPropertyChanged("Items");
                    Switching = false;
                }
            }
            UpdateCurrentSelection(1);
        }
        public void OnClick2()
        {
            if (Switching)
            {
                if (m_Inventory.SwapItems(SelectedInventorySlot, 2))
                {
                    OnPropertyChanged("Items");
                    Switching = false;
                }
            }
            UpdateCurrentSelection(2);
        }
        public void OnClick3()
        {
            if (Switching)
            {
                if (m_Inventory.SwapItems(SelectedInventorySlot, 3))
                {
                    OnPropertyChanged("Items");
                    Switching = false;
                }
            }
            UpdateCurrentSelection(3);
        }
        public void OnClick4()
        {
            if (Switching)
            {
                if (m_Inventory.SwapItems(SelectedInventorySlot, 4))
                {
                    OnPropertyChanged("Items");
                    Switching = false;
                }
            }
            UpdateCurrentSelection(4);
        }
        public void OnClick5()
        {
            if (Switching)
            {
                if (m_Inventory.SwapItems(SelectedInventorySlot, 5))
                {
                    OnPropertyChanged("Items");
                    Switching = false;
                }
            }
            UpdateCurrentSelection(5);
        }
        public void OnClick6()
        {
            if (Switching)
            {
                if (m_Inventory.SwapItems(SelectedInventorySlot, 6))
                {
                    OnPropertyChanged("Items");
                    Switching = false;
                }
            }
            UpdateCurrentSelection(6);
        }
        public void OnClick7()
        {
            if (Switching)
            {
                if (m_Inventory.SwapItems(SelectedInventorySlot, 7))
                {
                    OnPropertyChanged("Items");
                    Switching = false;
                }
            }
            UpdateCurrentSelection(7);
        }
        public void OnClick8()
        {
            if (Switching)
            {
                if (m_Inventory.SwapItems(SelectedInventorySlot, 8))
                {
                    OnPropertyChanged("Items");
                    Switching = false;
                }
            }
            UpdateCurrentSelection(8);
        }
        public void OnSwitchStart()
        {
            Switching = !Switching;
        }

        #region INotifyPropertyChanged Members  

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
