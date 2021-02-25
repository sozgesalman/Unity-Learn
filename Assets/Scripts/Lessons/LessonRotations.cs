using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    public class LessonRotations : MonoBehaviour
    {
        ///[SerializeField] private float _speed = 1;
        [SerializeField] private RotateSettings _rotateSettings;
        void Update()
        {
            transform.Rotate(Vector3.up, _rotateSettings.Speed * Time.deltaTime);
        }
    }
}