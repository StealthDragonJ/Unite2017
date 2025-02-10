using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RoboRyanTron.Unite2017
{
    public class StateMachine : MonoBehaviour
    {
        public List<State> states;

        public State currState;

        // NOTE: because GameEventListener sets itself onEnable we cannot do this OnAwake

        // Start is called before the first frame update
        void Start()
        {
            foreach (State state in states)
            {
                if (state != currState)
                {
                    state.OnStateExitEvent.Invoke();

                    Debug.Log("AAAAA");
                }
            }
        }

        void SwitchStates(State newState)
        {
            currState.OnStateExitEvent.Invoke();

            currState = newState;

            currState.OnStateEnterEvent.Invoke();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetButtonDown("Jump"))
            {
                if (currState == states[0])
                {
                    SwitchStates(states[1]);
                }
                else
                {
                    SwitchStates(states[0]);
                }
            }
        }
    }
}
