using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{
    public interface IObserver
    {
        void OnNotify(IEntity entity, Event ev);
    }
}
