/* * (Jerod Lockhart) 
 * * (Unit) 
 * * (Assignemnt2) 
 * * (This is the Unit class) 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit
{
    public float speed;

    public abstract string TryToDive();

    public abstract void ForwardAdvancement();

    public abstract void DiveAble();
}
