using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Assets.Scripts
{

    public enum JobType
    {
        Build,
        Worship
    }

    public class Worker
    {
        public SortedList<float, JobType> WorkPriorityList = new SortedList<float, JobType>();


    }
}
