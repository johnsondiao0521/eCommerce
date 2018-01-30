using System;

namespace DesignPatterns.Observer
{
    public class Student : IListener
    {
        private string name;
        public Student(string name)
        {
            this.name = name;
        }
        public void Update(string world)
        {
            Console.WriteLine(string.Format("老师对{0}说:{1}", name, world));
        }
    }
}
