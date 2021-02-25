using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Camera/Camera Settings")]
    public class CameraSettings : ScriptableObject
    {
        [Header("Rotation")]
        [SerializeField] private float _rotationLerpSpeed = 1;
        public float RotationLerpSpeed { get { return _rotationLerpSpeed; } }

        [Header("Position")]
        [SerializeField] private Vector3 _positionOffSet;
        public Vector3 PositionOffSet { get { return _positionOffSet; } }

        [SerializeField] private float _positionLerp = 1;
        public float PositionLerb { get { return _positionLerp; } }
    }
}
