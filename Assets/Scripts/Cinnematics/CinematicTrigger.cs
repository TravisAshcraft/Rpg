using System;
using UnityEngine;
using UnityEngine.Playables;
using RPG.Saving;

namespace RPG.Cinematics
{

    public class CinematicTrigger : MonoBehaviour, ISaveable
    {
        public bool isTriggered = false;

        private void OnTriggerEnter(Collider other)
        {
            if (!isTriggered && other.gameObject.tag == "Player") 
            {
                isTriggered = true;
                GetComponent<PlayableDirector>().Play();
            }
            
        }
        public object CaptureState()
        {
            return isTriggered;
        }

        public void RestoreState(object state)
        {
            isTriggered = (bool)state;
            if (!isTriggered)
            {
                isTriggered = true;
                GetComponent<PlayableDirector>().Play();
            }
            else
            {
                return;
            }
        }
    }
}
