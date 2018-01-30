using System;

namespace DesignPatterns
{
    /*
        延迟加载
         */
    public interface IDBQuery
    {
        string Request();
    }

    public class DBQuery : IDBQuery
    {
        public string Request()
        {
            return "request string";
        }
    }

    public class DBQueryProxy : IDBQuery
    {
        private DBQuery real = null;
        public string Request()
        {
            if (real == null)
            {
                real = new DBQuery();
            }
            return real.Request();
        }
    }
}
