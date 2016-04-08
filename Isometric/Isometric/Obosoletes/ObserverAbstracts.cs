using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Isometric.Obsoletes
{
    [Obsolete]
    public abstract class Observer
    {
        public virtual void Notify(Events e) { }
    }

    [Obsolete]
    public abstract class Subject
    {
        private List<Observer> observers = new List<Observer>(); //Create a list to hold observers
       
        /// <summary>
        /// Subscribes to this Subject
        /// </summary>
        /// <param name="o">The object that subsscribes</param>
        public void Subscribe(Observer o) { observers.Add(o); }

        /// <summary>
        /// Notify all observes about the specified event
        /// </summary>
        /// <param name="e">Specify event</param>
        protected void Notify(Events e)
        {
            for (int i = 0; i < observers.Count; i++)
            {
                observers[i].Notify(e);
            }
        }
    }

    public enum SubjectPoolSpots
    {
        InputHandler = 0x0001,
    }
    
    [Obsolete]
    public class SubjectPool
    {
        Subject[] pool = new Subject[1];
        
        public void AddSubject(int poolSpot,Subject s)
        {
            pool[poolSpot] = s;
        }

        public Subject GetSubject(int poolSpot)
        {
            return pool[poolSpot];
        }
    }
}
