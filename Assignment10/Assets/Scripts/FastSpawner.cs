using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace A10
{
    public class FastSpawner : MonoBehaviour
    {

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