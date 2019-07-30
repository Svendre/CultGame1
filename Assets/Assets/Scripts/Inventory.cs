using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Inventory
    {
        private SortedSet<Item> _items = new SortedSet<Item>(Item.Comparer);

        public Inventory()
        {

        }

        public Inventory(ICollection<Item> items)
        {
            foreach(var item in items)
            {
                _items.Add(item);
            }
        }

        /// <summary>
        /// True if item/items was added
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        //TODO: make better with .net 4.7.2 and TryGetValue
        public bool Add(Item item)
        {
            if (_items.Add(item))
            {
                return true;
            }
            else
            {
                Item old = _items.First(i => i.Type == item.Type);
                if (old.Type == Item.Types.Invalid) throw new NotImplementedException("fucing shit");
                _items.Remove(old);
                return _items.Add(new Item(item.Type, item.Count + old.Count));
            }
        }

        /// <summary>
        /// True is item/items was removed
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(Item item)
        {
            Item old = _items.First(i => i.Type == item.Type);
            if (old.Type == Item.Types.Invalid)
            {
                return false;
            }
            else
            {
                _items.Remove(old);
                int newCount = old.Count - item.Count;
                if(newCount > 0) _items.Add(new Item(item.Type, old.Count));
                return true;
            }
        }

        /// <summary>
        /// New inventory with items added from both lists
        /// </summary>
        /// <param name="i1"></param>
        /// <param name="i2"></param>
        /// <returns></returns>
        public static Inventory operator +(Inventory i1, Inventory i2)
        {
            Inventory i = new Inventory(i1._items);
            foreach(Item i2Item in i2._items)
            {
                i.Add(i2Item);
            }
            return i;
        }

        /// <summary>
        /// New inventory with all item is left, minus items in right. Can not have negative items
        /// </summary>
        /// <param name="i1"></param>
        /// <param name="i2"></param>
        /// <returns></returns>
        public static Inventory operator -(Inventory i1, Inventory i2)
        {
            Inventory i = new Inventory(i1._items);
            foreach (Item i2Item in i2._items)
            {
                i.Remove(i2Item);
            }
            return i;
        }

    }
