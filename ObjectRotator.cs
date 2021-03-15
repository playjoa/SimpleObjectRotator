using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JoaoMilone
{
    public class ObjectRotator : MonoBehaviour
    {
        [Tooltip("You can get pretty cool effects with differents speeds for each axis!")]
        [SerializeField]
        private bool rotateX = false, rotateY = false, rotateZ = false;

        [Tooltip("Speed of rotating!")]
        [SerializeField]
        private float vel_RotationX = 300f, vel_RotationY = 300f, vel_RotationZ = 300f; 

        void Rotate()
        {
            //Just plain old rotate xD

            if (rotateX)
            {
                transform.Rotate(new Vector3(vel_RotationX * Time.deltaTime, 0, 0), Space.Self);
            }

            if (rotateY)
            {
                transform.Rotate(new Vector3(0, vel_RotationY * Time.deltaTime, 0), Space.Self);
            }

            if (rotateZ)
            {
                transform.Rotate(new Vector3(0, 0, vel_RotationZ * Time.deltaTime), Space.Self);
            }
        }

        void Update()
        {
            Rotate();
        }
    }
}
