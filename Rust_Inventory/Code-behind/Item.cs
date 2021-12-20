using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Rust_Inventory.Code_behind
{
    class Item
    {
        #region Variables
        public int m_ItemID;
        public string m_ItemName;
        public int m_ItemCount;
        public float m_ItemDamage;
        public string m_ItemSprite;
        public float m_ItemRangeOfEffect;
        public float m_ItemDurability;

        //These are not exposed to the ItemViewModel
        public int m_SomeNonExposedVariable = 69;
        public string m_NotExposedToTheView = "This is never on the view";
        #endregion


    }
}
