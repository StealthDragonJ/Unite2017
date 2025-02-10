using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RoboRyanTron.Unite2017.Variables;

namespace RoboRyanTron.Unite2017
{
    public class FloatInput : MonoBehaviour
    {
        public string inputAxisName = "Horizontal";

        public FloatVariable move;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            move.SetValue(Input.GetAxis("Horizontal"));
        }
    }
}
