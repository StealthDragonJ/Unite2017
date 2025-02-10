using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace RoboRyanTron.Unite2017
{
    public class State : MonoBehaviour
    {
        public UnityEvent OnStateEnterEvent;
        public UnityEvent OnStateUpdateEvent;
        public UnityEvent OnStateFixedUpdateEvent;
        public UnityEvent OnStateExitEvent;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
