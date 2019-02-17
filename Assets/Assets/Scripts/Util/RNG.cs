using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    static class RNG
    {
        private static Random _random = new Random(DateTime.Now.Millisecond* DateTime.Now.Year);

        /// <summary>
        /// Return random integer [0-size>
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public static int Int(int size)
        {
            return _random.Next(0, size);
        }

        public static float Float()
        {
            return (float)_random.NextDouble();
        }
    }
}
