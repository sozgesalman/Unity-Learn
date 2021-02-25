using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    [CreateAssetMenu(menuName = "Lessons/Lesson1/Control Rigidbody Settings")]
    public class RigidbodySettings : ScriptableObject
    {
        [SerializeField] private Vector3 _jumpforce;
        public Vector3 Jumpforce {get { return _jumpforce; } }
    }
}