using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RoboRyanTron.Unite2017.Variables;

namespace RoboRyanTron.Unite2017
{
    public class MovementTest : MonoBehaviour
    {
        public FloatReference moveSpeed;

        public FloatVariable currMoveDirection;

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
            float movement = currMoveDirection.Value * moveSpeed.Value;

            rb.velocity = new Vector3(movement, 0f, 0f);
        }
    }
}