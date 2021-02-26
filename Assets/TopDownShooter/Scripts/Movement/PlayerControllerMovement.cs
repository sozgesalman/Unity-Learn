using System.Collections;
using System.Collections.Generic;
using TopDownShooter.PlayerInput;
using UnityEngine;

namespace TopDownShooter.PlayerMovement
{
    public class PlayerControllerMovement : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidBody;
        [SerializeField] private InputData _inputData;
        [SerializeField] private PlayerMovementSettings _playerMovementSettings;
        private void Update()
        {
            _rigidBody.MovePosition(_rigidBody.position + ( _rigidBody.transform.forward * _inputData.Vertical * _playerMovementSettings.VerticalSpeed));
            _rigidBody.MovePosition(_rigidBody.position + ( _rigidBody.transform.right * _inputData.Horizontal * _playerMovementSettings.HorizontalSpeed));
        }
    }
}
