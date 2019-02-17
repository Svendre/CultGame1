using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Assets.Scripts
{
    public abstract class Skill
    {
        private static float[] _levelValues = new float[] {
            0.25f, //Level 1
            0.50f, //Level 2
            1.00f, //Level 3
            1.25f, //Level 4
            1.50f, //Level 5
            1.75f, //Level 6
            2.00f, //Level 7
            2.50f, //Level 8
            3.00f, //Level 9
            4.00f, //Level 10
        };

        public abstract string Name { get; }
        public int Level { get; set; }
        public float Value { get { return _levelValues[Level + 1]; } }

        public static List<Skill> GenerateDefaultSkills()
        {
            return new List<Skill>(new Skill[]
            {
                new Building
                {
                    Level = 3
                },
                new Worshiping
                {
                    Level = 3,
                }
            });
        }
        
    }

    public class Building : Skill
    {
        public override string Name { get; } = "Building";
    }

    public class Worshiping : Skill
    {
        public override string Name { get; } = "Worshiping";
    }
}

