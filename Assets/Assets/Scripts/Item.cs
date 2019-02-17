using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Assets.Scripts
{
    public struct Item 
    {
        public static IItemComparer Comparer = new IItemComparer();

        public enum Types : byte
        {
            Invalid,
            Wood,
            Stone
        }
        public Types Type;
        public int Count;

        public Item(Types type)
        {
            Type = type;
            Count = 1;
        }

        public Item(Types type, int count)
        {
            Type = type;
            Count = count;
        }
    }

    public class IItemComparer : IComparer<Item>
    {
        public int Compare(Item x, Item y)
        {
            //int result = ((byte)x.Type).CompareTo((byte)x.Type);
            //if (result != 0) return result;
            //return x.Count.CompareTo(y);
            return ((byte)x.Type).CompareTo((byte)x.Type);
        }
    }


}
