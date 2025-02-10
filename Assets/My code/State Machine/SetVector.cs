using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RoboRyanTron.Unite2017.Variables;

namespace RoboRyanTron.Unite2017
{
    public class SetVector : MonoBehaviour
    {
        public Vector3Variable Vector3;

        public FloatReference X;
        public FloatReference Y;
        public FloatReference Z;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            Vector3.SetValue(new Vector3(X.Value, Y.Value, Z.Value));
        }
    }
}
