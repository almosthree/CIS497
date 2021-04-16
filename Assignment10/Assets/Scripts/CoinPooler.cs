﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace A10 { 
    public class CoinPooler : MonoBehaviour
    {        public List<Pool> pools;

        public Dictionary<string, Queue<GameObject>> poolDictionary;


        #region This code makes this class a Singleton

        public static CoinPooler instance;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }
        #endregion


        void Start()
        {
            poolDictionary = new Dictionary<string, Queue<GameObject>>();

            FillPoolsWithInactiveObjects();
        }

        private void FillPoolsWithInactiveObjects()
        {
            foreach (Pool pool in pools)
            {
                Queue<GameObject> objectPool = new Queue<GameObject>();

                for (int i = 0; i < pool.size; i++)
                {
                    GameObject obj = Instantiate(pool.prefab);
                    obj.SetActive(false);
                    objectPool.Enqueue(obj);
                }
                poolDictionary.Add(pool.tag, objectPool);
            }
        }


        public GameObject SpawnFromPool(string tag, Vector3 position, Quaternion rotation)
        {
            if (!poolDictionary.ContainsKey(tag))
            {
                Debug.LogWarning("Pool with tag " + tag + " doesn't exist.");
                return null;
            }

            GameObject objectToSpawn = poolDictionary[tag].Dequeue();

            objectToSpawn.SetActive(true);
            objectToSpawn.transform.position = position;
            objectToSpawn.transform.rotation = rotation;

            poolDictionary[tag].Enqueue(objectToSpawn);

            return objectToSpawn;
        }

        public void ReturnObjectToPool(string tag, GameObject objectToReturn)
        {
            objectToReturn.SetActive(false);

            poolDictionary[tag].Enqueue(objectToReturn);

        }

}
}