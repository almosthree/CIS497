using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern
{
    public abstract class RuneDecorator : Sword
    {

        public override abstract string GetDescription();
    }
}

