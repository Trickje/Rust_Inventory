using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rust_Inventory.Code_behind
{
    class Inventory
    {
        public IList<Item> m_ItemList;
        
        //Inventory functionality that is called by the Inventory View Model
        public bool SwapItems(int index1, int index2)
        {
            if(index1 == index2)
            {
                return false;
            }
            Item temp = m_ItemList[index1];
            m_ItemList[index1] = m_ItemList[index2];
            m_ItemList[index2] = temp;
            return true;
        }

        public Inventory()
        {
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
        }
    }
}
