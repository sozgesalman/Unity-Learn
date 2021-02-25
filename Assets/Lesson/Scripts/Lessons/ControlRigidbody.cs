using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    public class ControlRigidbody : MonoBehaviour
    {
        [SerializeField] Rigidbody _rigidbody;
        
        [SerializeField] private RigidbodySettings _setting;

        private void Update()
        {
            bool spaceKeyDown = Input.GetKeyDown(KeyCode.Space);

            if (spaceKeyDown)
            {
                _rigidbody.AddForce(_setting.Jumpforce, ForceMode.Impulse);
            }
        }

    }
}