using System;

namespace DesignPatterns
{
    public class ProxyLogging : Logger
    {
        private readonly RealLogging realLogging = new RealLogging();

        public bool ValiDate(string msg)
        {
            return true;
        }
        public override void Log(string msg)
        {
            if (ValiDate(msg))
            {
                realLogging.Log(msg);
            }
        }


        public void PostRequest()
        {

        }
    }

    public abstract class Logger
    {
        public abstract void Log(string msg);
    }

    public class RealLogging : Logger
    {
        public override void Log(string msg)
        {
            Console.WriteLine("真实的写入数据库.........");
        }
    }
}
