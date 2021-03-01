/* * (Jerod Lockhart) 
 * * (powerup) 
 * * (Assignment1) 
 * * (This code makes the makes the power up work) 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Powerup : MonoBehaviour
{
    [SerializeField] protected float cooldownTime;
    public abstract IEnumerator Activate();
    public abstract void Deactivate();

}
