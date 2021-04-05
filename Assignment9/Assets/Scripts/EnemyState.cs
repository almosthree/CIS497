using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace A9 {
    public interface EnemyState 
    {
        void Stunned();
        void Attack();
        void StunRecover();
        void CounterAttack();
        void Defend();

    }
}