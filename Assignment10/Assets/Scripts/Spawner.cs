
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace A10 { 
    public class Spawner : MonoBehaviour
    {

        public GameObject prefabToSpawn;

        void FixedUpdate()
        {
            Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        }
    }
}