using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class Teacher : HumanEvent
    {
        public void Say(string world)
        {
            Console.WriteLine(string.Format("老师说:{0}", world));
            NotifyListener(world);
        }
    }
}
