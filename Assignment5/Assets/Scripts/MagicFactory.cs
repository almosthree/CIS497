using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFactoryPatternWithGameObjects
{

    //Attach this class to an empty GameObject
    public class MagicFactory : MonoBehaviour
    {
        public GameObject IcePrefab;
        public GameObject FirePrefab;
        public GameObject ThunderPrefab;

        private GameObject enemyToSpawn;

        public GameObject CreateEnemy(string type)
        {
            enemyToSpawn = null;

            if (type.Equals("Zombie"))
            {
                enemyToSpawn = IcePrefab;

                //If there is not already a Zombie script attached to the prefab, attach one
                if (enemyToSpawn.GetComponent<Zombie>() == null)
                {
                    enemyToSpawn.AddComponent<Zombie>();
                }
            }
            else if (type.Equals("Vampire"))
            {
                enemyToSpawn = FirePrefab;

                //If there is not already a Vampire script attached to the prefab, attach one
                if (enemyToSpawn.GetComponent<Vampire>() == null)
                {
                    enemyToSpawn.AddComponent<Vampire>();
                }

            }
            else if (type.Equals("Werewolf"))
            {
                enemyToSpawn = ThunderPrefab;

                //If there is not already a Werewolf script attached to the prefab, attach one
                if (enemyToSpawn.GetComponent<Werewolf>() == null)
                {
                    enemyToSpawn.AddComponent<Werewolf>();
                }

            }

            Debug.Log("Factory sending: " + enemyToSpawn);
            return enemyToSpawn;
        }

    }
}