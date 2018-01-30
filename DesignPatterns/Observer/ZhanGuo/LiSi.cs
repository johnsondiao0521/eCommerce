using System;

namespace DesignPatterns.Observer.ZhanGuo
{
    /// <summary>
    /// 观察者
    /// </summary>
    public class LiSi
    {
        public string Name { get; private set; }
        public LiSi(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 收到反馈信息作出响应
        /// </summary>
        /// <param name="actionMsg"></param>
        public void Action(string actionMsg)
        {
            Console.WriteLine("李斯收到韩非子的卧底信息，马上报告秦始皇");
            ReportToQiShiHuang(actionMsg);
        }

        private void ReportToQiShiHuang(string message)
        {
            Console.WriteLine("报告秦始皇陛下 韩非子进行了" + message);
        }
    }
}
