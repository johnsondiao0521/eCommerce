using System;

namespace DesignPatterns.Observer.ZhanGuo
{
    /// <summary>
    /// 被观察者 李斯派人监视韩非子
    /// </summary>
    public class HanFeiZi
    {
        public event Action<string> ActionEventHandler;

        /// <summary>
        /// 通知观察者发生了事情
        /// </summary>
        /// <param name="message"></param>
        public void Notify(string message)
        {
            ActionEventHandler?.Invoke(message);
        }

        public void Eat()
        {
            Console.WriteLine("韩非子吃饭了");
            Notify("韩非子吃饭了");
        }

        public void Happy()
        {
            Console.WriteLine("韩非子在哈哈哈大笑 好高兴");
            Notify("韩非子在哈哈哈大笑 好高兴");
        }
    }
}
