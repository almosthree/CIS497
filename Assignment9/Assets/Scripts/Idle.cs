using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace A9
{
    public class Idle : EnemyState
    {
        CombatImplementation combatAI;
        private CombatImplementation combatImplementation;

        public Idle(CombatImplementation combatImplementation)
        {
            this.combatImplementation = combatImplementation;
        }

        public void Attack()
        {
            throw new System.NotImplementedException();
        }

        public void CounterAttack()
        {
            throw new System.NotImplementedException();
        }

        public void Defend()
        {
            throw new System.NotImplementedException();
        }

        public void Stunned()
        {
            throw new System.NotImplementedException();
        }

        public void StunRecover()
        {
            throw new System.NotImplementedException();
        }

    }
}