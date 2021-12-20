﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Rust_Inventory.Code_behind
{
    class ItemViewModel : INotifyPropertyChanged
    {
        private IList<ItemBase> m_ItemList;
        public int SelectedInventorySlot;
        private bool m_Switching;
        public bool Switching
        {
            get
            {
                return m_Switching;
            }
            set
            {
                if(value == false)
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
        
        private ItemBase m_CurrentSelectedItem;
        public ItemBase CurrentSelectedItem {
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
            m_CurrentSelectedItem = Items[SelectedInventorySlot];
            OnPropertyChanged("CurrentSelectedItem");
            
        }

        public void SwapItems(int index1, int index2)
        {
            ItemBase temp = Items[index1];
            Items[index1] = Items[index2];
            Items[index2] = temp;
            Switching = false;
            SwitchString = "Not Swapping";
            OnPropertyChanged("Items");
        }

        public ItemViewModel()
        {
            SelectedInventorySlot = 0;
            Switching = false;
            SwitchString = "Not Swapping";
            m_ItemList = new List<ItemBase>
            {
                new ItemBase{
                    ItemID= 1,
                    ItemName ="AK 47",
                    ItemCount=1,
                    ItemDamage=120.0f,
                    ItemSprite="AK_StockImage.jpg",
                    ItemRangeOfEffect=50.0f,
                    ItemDurability=100.0f
                },
                new ItemBase{
                    ItemID= 2,
                    ItemName ="Pistol (Silenced)",
                    ItemCount=1,
                    ItemDamage=80.0f,
                    ItemSprite="Pistol_Silenced.jpg",
                    ItemRangeOfEffect=30.0f,
                    ItemDurability=100.0f
                },
                new ItemBase{
                    ItemID= 0,
                    ItemName ="Empty",
                    ItemCount=0,
                    ItemDamage=0.0f,
                    ItemSprite="Empty.png",
                    ItemRangeOfEffect=0.0f,
                    ItemDurability=0.0f
                },
                new ItemBase{
                    ItemID= 0,
                    ItemName ="Empty",
                    ItemCount=0,
                    ItemDamage=0.0f,
                    ItemSprite="Empty.png",
                    ItemRangeOfEffect=0.0f,
                    ItemDurability=0.0f
                },
                new ItemBase{
                    ItemID= 0,
                    ItemName ="Empty",
                    ItemCount=0,
                    ItemDamage=0.0f,
                    ItemSprite="Empty.png",
                    ItemRangeOfEffect=0.0f,
                    ItemDurability=0.0f
                },
                new ItemBase{
                    ItemID= 0,
                    ItemName ="Empty",
                    ItemCount=0,
                    ItemDamage=0.0f,
                    ItemSprite="Empty.png",
                    ItemRangeOfEffect=0.0f,
                    ItemDurability=0.0f
                },
                new ItemBase{
                    ItemID= 0,
                    ItemName ="Empty",
                    ItemCount=0,
                    ItemDamage=0.0f,
                    ItemSprite="Empty.png",
                    ItemRangeOfEffect=0.0f,
                    ItemDurability=0.0f
                },
                new ItemBase{
                    ItemID= 0,
                    ItemName ="Empty",
                    ItemCount=0,
                    ItemDamage=0.0f,
                    ItemSprite="Empty.png",
                    ItemRangeOfEffect=0.0f,
                    ItemDurability=0.0f
                },
                new ItemBase{
                    ItemID= 0,
                    ItemName ="Empty",
                    ItemCount=0,
                    ItemDamage=0.0f,
                    ItemSprite="Empty.png",
                    ItemRangeOfEffect=0.0f,
                    ItemDurability=0.0f
                }
            };

            m_CurrentSelectedItem = Items[SelectedInventorySlot];
        }
        public IList<ItemBase> Items
        {
            get { return m_ItemList; }
            set { m_ItemList = value; }
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
        public void OnClick0()
        {
            if (Switching)
            {
                SwapItems(SelectedInventorySlot, 0);
            }
            UpdateCurrentSelection(0);
        }
        public void OnClick1()
        {
            if (Switching)
            {
                SwapItems(SelectedInventorySlot, 1);
            }
            UpdateCurrentSelection(1);
        }
        public void OnClick2()
        {
            if (Switching)
            {
                SwapItems(SelectedInventorySlot, 2);
            }
            UpdateCurrentSelection(2);
        }
        public void OnClick3()
        {
            if (Switching)
            {
                SwapItems(SelectedInventorySlot, 3);
            }
            UpdateCurrentSelection(3);
        }
        public void OnClick4()
        {
            if (Switching)
            {
                SwapItems(SelectedInventorySlot, 4);
            }
            UpdateCurrentSelection(4);
        }
        public void OnClick5()
        {
            if (Switching)
            {
                SwapItems(SelectedInventorySlot, 5);
            }
            UpdateCurrentSelection(5);
        }
        public void OnClick6()
        {
            if (Switching)
            {
                SwapItems(SelectedInventorySlot, 6);
            }
            UpdateCurrentSelection(6);
        }
        public void OnClick7()
        {
            if (Switching)
            {
                SwapItems(SelectedInventorySlot, 7);
            }
            UpdateCurrentSelection(7);
        }
        public void OnClick8()
        {
            if (Switching)
            {
                SwapItems(SelectedInventorySlot, 8);
            }
            UpdateCurrentSelection(8);
        }
        public void OnSwitchStart()
        {
            Switching = !Switching;
        }
    }
}
