/* * (Jerod Lockhart) 
 * * (RuneDecorator) 
 * * (Assignment4) 
 * * (This is the Decorator for the runes to the sword) 
 */
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

