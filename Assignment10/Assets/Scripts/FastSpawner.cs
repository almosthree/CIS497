using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace A10
{
    public class FastSpawner : MonoBehaviour
    {

        //We could call our ObjectPooler Singleton like this
        /*
        void FixedUpdate()
        {
            ObjectPooler.instance.SpawnFromPool("Sphere", transform.position, Quaternion.identity);
        }
        */

        //But creating a reference to our ObjectPooler may be faster in terms of performance
        ObjectPooler objectPooler;

        private void Start()
        {
            objectPooler = ObjectPooler.instance;
        }

        void FixedUpdate()
        {
            objectPooler.SpawnFromPool("Coin", transform.position, Quaternion.identity);
        }
    }
}