using System;

namespace DesignPatterns.Observer
{
    public class ObserverTest
    {
        public static void Do()
        {
            Teacher teacher = new Teacher();
            teacher.AddListener(new Student("刁志达"));
            teacher.AddListener(new Student("印宝剑"));
            teacher.AddListener(new Student("曾敏"));

            teacher.Say("上课啦!!!!");
            Console.ReadKey();
        }
    }
}
