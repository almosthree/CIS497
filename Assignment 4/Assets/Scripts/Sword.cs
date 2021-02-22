using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern
{
    public abstract class Sword
    {
        
        public string description = "Your trusty Longsword";
        public virtual string GetDescription()
        {
            return description;
        }

        public abstract int GetDamage();
    }
}