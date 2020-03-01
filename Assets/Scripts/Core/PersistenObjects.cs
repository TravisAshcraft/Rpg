using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    public class PersistenObjects : MonoBehaviour
    {
        [SerializeField] GameObject persistentObject;
        static bool hasSpawned = false;
        private void Awake()
        {
            if (hasSpawned) { return; }

            persistentObj();

            hasSpawned = false;

            
        }

        private void persistentObj()
        {
            GameObject fader = Instantiate(persistentObject);
            DontDestroyOnLoad(fader);

        }
    }

}