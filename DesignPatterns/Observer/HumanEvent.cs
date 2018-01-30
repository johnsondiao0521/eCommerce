
using System.Collections.Generic;


namespace DesignPatterns.Observer
{
    public class HumanEvent
    {
        List<IListener> listeners = new List<IListener>();

        public void AddListener(IListener listener)
        {
            listeners.Add(listener);
        }

        public void RemoveListener(IListener listener)
        {
            listeners.Remove(listener);
        }

        public void NotifyListener(string world)
        {
            foreach (var listener in listeners)
            {
                listener.Update(world);
            }
        }
    }
}
