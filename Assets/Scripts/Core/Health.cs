﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Saving;

namespace RPG.Core
{
    public class Health : MonoBehaviour, ISaveable
    {
       [SerializeField] float health = 100f;
        bool isDead = false;

        public bool IsDead(){return isDead;}

        public void TakeDamage(float damage)
        {
            health = Mathf.Max(health - damage, 0); //this does not allow the health to fall below 0
            if (health == 0)
            {
                Die();
            }
        }

        private void Die()
        {
            if (isDead) return;
            isDead = true;
            GetComponent<Animator>().SetTrigger("die");
            GetComponent<ActionScheduler>().CancelCurrentAction();
        }
        public object CaptureState()
        {
            return health;
        }

        public void RestoreState(object state)
        {
            health = (float)state; //you have to change the state to whatever your trying to cast in. 
            if (health == 0)
            {
                Die();
            }
        }
    }
}
