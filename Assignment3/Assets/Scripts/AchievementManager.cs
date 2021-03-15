using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{ 
public class AchievementsManager : IObserver
{
    public void OnNotify(IEntity entity, Event ev)
    {
        switch (ev)
        {
            case Event.jumpfive():
                bool isEntityCharacter = (entity as Character) != null;
                if (isEntityCharacter)
                {
                    this.UnlockAchievement(Achievement.jumpfive);
                }

                break;

                // Other cases...
        }
    }
}
}