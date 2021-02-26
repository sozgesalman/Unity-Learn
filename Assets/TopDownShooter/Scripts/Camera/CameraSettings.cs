using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Camera
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Camera/Camera Settings")]
    public class CameraSettings : ScriptableObject
    {
        [Header("Rotation")]
        [SerializeField] private float _rotationLerpSpeed = 1;
        public float RotationLerpSpeed { get { return _rotationLerpSpeed; } }

        //Kameranın player'a x,y,z düzleminde bakma yerini ayarlayabilmek için kullanıyoruz.
        [Header("Position")]
        [SerializeField] private Vector3 _positionOffSet; 
        public Vector3 PositionOffSet { get { return _positionOffSet; } }

        [SerializeField] private float _positionLerp = 1;
        public float PositionLerb { get { return _positionLerp; } }
    }
}
