using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rust_Inventory.Code_behind
{
    class Inventory
    {
        private IList<Item> m_ItemList;
        public IList<ItemViewModel> ItemsVM;
        public bool SwapItems(int index1, int index2)
        {
            if(index1 == index2)
            {
                return false;
            }
            Item temp = m_ItemList[index1];
            m_ItemList[index1] = m_ItemList[index2];
            m_ItemList[index2] = temp;
            ItemViewModel tempVM = ItemsVM[index1];
            ItemsVM[index1] = ItemsVM[index2];
            ItemsVM[index2] = tempVM;
            return true;
        }

        public Inventory()
        {
            ItemsVM = new List<ItemViewModel>();
            m_ItemList = new List<Item>
            {
                new Item{
                    m_ItemID= 1,
                    m_ItemName ="AK 47",
                    m_ItemCount=1,
                    m_ItemDamage=120.0f,
                    m_ItemSprite="AK_StockImage.jpg",
                    m_ItemRangeOfEffect=50.0f,
                    m_ItemDurability=100.0f
                },
                new Item{
                    m_ItemID= 2,
                    m_ItemName ="Pistol (Silenced)",
                    m_ItemCount=1,
                    m_ItemDamage=80.0f,
                    m_ItemSprite="Pistol_Silenced.jpg",
                    m_ItemRangeOfEffect=30.0f,
                    m_ItemDurability=100.0f
                },
                new Item{
                    m_ItemID= 0,
                    m_ItemName ="Empty",
                    m_ItemCount=0,
                    m_ItemDamage=0.0f,
                    m_ItemSprite="Empty.png",
                    m_ItemRangeOfEffect=0.0f,
                    m_ItemDurability=0.0f
                },
                new Item{
                    m_ItemID= 0,
                    m_ItemName ="Empty",
                    m_ItemCount=0,
                    m_ItemDamage=0.0f,
                    m_ItemSprite="Empty.png",
                    m_ItemRangeOfEffect=0.0f,
                    m_ItemDurability=0.0f
                },
                new Item{
                    m_ItemID= 0,
                    m_ItemName ="Empty",
                    m_ItemCount=0,
                    m_ItemDamage=0.0f,
                    m_ItemSprite="Empty.png",
                    m_ItemRangeOfEffect=0.0f,
                    m_ItemDurability=0.0f
                },
                new Item{
                    m_ItemID= 0,
                    m_ItemName ="Empty",
                    m_ItemCount=0,
                    m_ItemDamage=0.0f,
                    m_ItemSprite="Empty.png",
                    m_ItemRangeOfEffect=0.0f,
                    m_ItemDurability=0.0f
                },
                new Item{
                    m_ItemID= 0,
                    m_ItemName ="Empty",
                    m_ItemCount=0,
                    m_ItemDamage=0.0f,
                    m_ItemSprite="Empty.png",
                    m_ItemRangeOfEffect=0.0f,
                    m_ItemDurability=0.0f
                },
                new Item{
                    m_ItemID= 0,
                    m_ItemName ="Empty",
                    m_ItemCount=0,
                    m_ItemDamage=0.0f,
                    m_ItemSprite="Empty.png",
                    m_ItemRangeOfEffect=0.0f,
                    m_ItemDurability=0.0f
                },
                new Item{
                    m_ItemID= 0,
                    m_ItemName ="Empty",
                    m_ItemCount=0,
                    m_ItemDamage=0.0f,
                    m_ItemSprite="Empty.png",
                    m_ItemRangeOfEffect=0.0f,
                    m_ItemDurability=0.0f
                }
            };
            foreach(Item item in m_ItemList)
            {
                ItemsVM.Add(new ItemViewModel(item));
            }
        }
    }
}
