using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownShooter.PlayerInput;

namespace TopDownShooter.PlayerControls {
    public class WheelRotationManagement : MonoBehaviour
    {
         [SerializeField] private Rigidbody _rigidBody;
        [SerializeField] private InputData _rotationInput;
        [SerializeField] private Transform _wheelTransform;
        [SerializeField] private WheelRotationSettings _wheelRotationSettings;

        private void Update()
        {
            _wheelTransform.transform.Rotate(_rotationInput.Vertical * _wheelRotationSettings.RotationSpeed, 0, 0, Space.Self);
            //_wheelTransform.transform.Rotate(Vector3.up*_wheelRotationSettings.RotationSpeed, _wheelRotationSettings.RotationAngle);
           
        }
    } 
}
