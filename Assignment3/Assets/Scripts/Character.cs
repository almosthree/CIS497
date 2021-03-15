using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{
    public class Character : IEntity, IObservable
    {
        private List<IObserver> observers;

        // IEntity interface implementation
        public virtual void PhysicsUpdate()
        {
            // Apply gravity and stuff...

            if (this.jumpfive())
            {
                this.NotifyObservers(this, Event.jumpfive());
            }
        }
        // END IEntity interface implementation

        // IObservable interface implementation

        public void RemoveObserver(IObserver observer)
        {
            
        }

        public void NotifyObservers(IEntity entity, Event ev)
        {
            foreach (var observer in this.observers)
            {
                observer.OnNotify(entity, ev);
            }
        }

        public void JumpsUpdate()
        {
            throw new System.NotImplementedException();
        }

        public void DeathUpdate()
        {
            throw new System.NotImplementedException();
        }

        public void NotifyObservers(IEntity entity, Event ev)
        {
            throw new System.NotImplementedException();
        }

        public void AddObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void NotifyObservers(IEntity entity, Event ev)
        {
            throw new System.NotImplementedException();
        }
        // END IObservable interface implementation
    }
}