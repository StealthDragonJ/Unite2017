using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RoboRyanTron.Unite2017.Variables;

namespace RoboRyanTron.Unite2017
{
    public class ApplyVelocity : MonoBehaviour
    {
        public Vector3Variable velocityToApply;

        public Rigidbody rb;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void FixedUpdate()
        {
            rb.velocity = velocityToApply.Value;
        }
    }
}