﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerControls

{
    [CreateAssetMenu(menuName ="TopDown Shooter/Player/Movement Settings")] 
    public class PlayerMovementSettings : ScriptableObject
    {
        public float HorizontalSpeed = 5;
        public float VerticalSpeed = 5;

        //[SerializeField] private Vector3 _jumpForce;
        //public Vector3 JumpForce { get { return _jumpForce; } }
    }
}