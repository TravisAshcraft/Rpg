using System;
using UnityEngine;
using UnityEngine.Playables;

namespace RPG.Cinematics
{

    public class CinematicTrigger : MonoBehaviour
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
    }
}
