using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace A9
{
    public class CombatImplementation : MonoBehaviour
    {
        private EnemyState idleState;

        public EnemyState returntoStartState { get; set; }
        public EnemyState idle { get; set; }
        public EnemyState stunned { get; set; }
        public EnemyState currentState { get; set; }

        public bool inRange { get; set; }

        // Start is called before the first frame update
        void Start()
        {
            returntoStartState = (EnemyState)gameObject.AddComponent<ReturntoStartState>();
            stunned = (EnemyState)gameObject.AddComponent<Stunned>();
            idle = new Idle(this);

            currentState = idleState;
            inRange = false;
        }

        public void defend() { currentState.Defend(); }
        public void attack() { currentState.Attack(); }
        public void recoverFromStunned() { currentState.StunRecover(); }
        public void counterAttack() { currentState.CounterAttack(); }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
