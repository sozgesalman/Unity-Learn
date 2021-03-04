using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownShooter.PlayerInput;

namespace TopDownShooter.PlayerControls
{
    public class TowerRotationController : MonoBehaviour
    {
        [SerializeField] private InputData _rotationInput;
        [SerializeField] private Transform _towerTransform;
        [SerializeField] private TowerRotationSetting _towerRotationSettings;

        private void Update()
        {
            _towerTransform.transform.Rotate(0, _rotationInput.Horizontal*_towerRotationSettings.RotationSpeed, 0, Space.Self);
        }
    }
}
