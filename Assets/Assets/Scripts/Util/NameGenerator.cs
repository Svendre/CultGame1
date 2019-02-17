using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class NameGenerator
    {
        private static string[] _firstNames = { "Dave", "Dave", "Dave" };
        private static string[] _middleNames = { "Dave", "Dave", "Dave" };
        private static string[] _lastNames = { "Daveson", "Daveson", "Daveson" };
        private static float _middleNameChance = 0f;

        public static string GetFullName()
        {
            return $"{GetFirstName()} {(1 - _middleNameChance <= RNG.Float() ? GetMiddleName() : "")} {GetLastName()}";
        }

        public static string GetFirstName()
        {
            return _firstNames[RNG.Int(_firstNames.Length)];
        }

        public static string GetMiddleName()
        {
            return _middleNames[RNG.Int(_middleNames.Length)];
        }

        public static string GetLastName()
        {
            return _lastNames[RNG.Int(_lastNames.Length)];
        }

    }
}
