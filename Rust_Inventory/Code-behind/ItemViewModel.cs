using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Rust_Inventory.Code_behind
{
    class ItemViewModel : INotifyPropertyChanged
    {
        private Item m_Target;
        private int m_ItemID;
        private string m_ItemName;
        private int m_ItemCount;
        private float m_ItemDamage;
        private string m_ItemSprite;
        private float m_ItemRangeOfEffect;
        private float m_ItemDurability;
        public int ItemID
        {
            get
            {
                return m_ItemID;
            }
            set
            {
                m_ItemID = value;
                m_Target.m_ItemID = value;
                OnPropertyChanged("ItemID");
            }
        }
        public string ItemName
        {
            get
            {
                return m_ItemName;
            }
            set
            {
                m_ItemName = value;
                m_Target.m_ItemName = value;
                OnPropertyChanged("ItemName");
            }
        }
        public int ItemCount
        {
            get
            {
                return m_ItemCount;
            }
            set
            {
                m_ItemCount = value;
                m_Target.m_ItemCount = value;
                OnPropertyChanged("ItemCount");
            }
        }

        public float ItemDamage
        {
            get
            {
                return m_ItemDamage;
            }
            set
            {
                m_ItemDamage = value;
                m_Target.m_ItemDamage = value;
                OnPropertyChanged("ItemDamage");
            }
        }
        public string ItemSprite
        {
            get
            {
                return m_ItemSprite;
            }
            set
            {
                m_ItemSprite = value;
                m_Target.m_ItemSprite = value;
                OnPropertyChanged("ItemSprite");
            }
        }

        public float ItemRangeOfEffect
        {
            get
            {
                return m_ItemRangeOfEffect;
            }
            set
            {
                m_ItemRangeOfEffect = value;
                m_Target.m_ItemRangeOfEffect = value;
                OnPropertyChanged("ItemRangeOfEffect");
            }
        }
        public float ItemDurability
        {
            get
            {
                return m_ItemDurability;
            }
            set
            {
                m_ItemDurability = value;
                m_Target.m_ItemDurability = value;
                OnPropertyChanged("ItemDurability");
            }
        }


        public ItemViewModel(Item a_Target)
        {
            m_Target = a_Target;
            ItemID = a_Target.m_ItemID;
            ItemName = a_Target.m_ItemName;
            ItemCount = a_Target.m_ItemCount;
            ItemDamage = a_Target.m_ItemDamage;
            ItemSprite = a_Target.m_ItemSprite;
            ItemRangeOfEffect = a_Target.m_ItemRangeOfEffect;
            ItemDurability = a_Target.m_ItemDurability;
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
