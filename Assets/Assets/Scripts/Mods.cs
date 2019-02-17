using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    struct ModResult
    {
        public float value;
        public Mod[] mods;
        public ModResult(float start, Mod[] mods, bool withMods = false)
        {
            value = mods.Select(mod => mod.value).Aggregate(start, (x, y) => x * y);
            if (withMods)
            {
                this.mods = mods;
            }
            else
            {
                this.mods = null;
            }
        }
    }

    struct Mod
    {
        public byte nameIndex;
        public float value;
    }
}
