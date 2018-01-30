using System;

namespace DesignPatterns.Observer.ZhanGuo
{
    public class ZhanGuoTest
    {
        public static void Do()
        {
            LiSi lisi = new LiSi("李斯");
            HanFeiZi hanfeizi = new HanFeiZi();
            hanfeizi.ActionEventHandler += lisi.Action;
            hanfeizi.Eat();
        }
    }
}
