using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TopDownShooter.PlayerInput
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Input/Input Data")]
    public class InputData : ScriptableObject
    {
        public float Horizontal;
        public float Vertical;

        [Header("Axis Base Control")]
        [SerializeField] private bool _axisActive;
        [SerializeField] private string _AxisNameHorizontal;
        [SerializeField] private string _AxisNameVertical;

        [Header("Key Base Control")]

        [SerializeField] private bool _keyBaseHorizontalActive;
        [SerializeField] private KeyCode PositiveHorizontalKeyCode;
        [SerializeField] private KeyCode NegativeHorizontalKeyCode;

        [SerializeField] private bool _keyBaseVerticalActive;
        [SerializeField] private KeyCode PositiveVerticalKeyCode;
        [SerializeField] private KeyCode NegativeVerticalKeyCode;
        [SerializeField] private float _increaseAmount = 0.015f;


        public void ProcessInput()
        {
            if (_axisActive)
            {
                Horizontal = Input.GetAxis(_AxisNameHorizontal);
                Vertical = Input.GetAxis(_AxisNameVertical);
            }
            else
            {
                if (_keyBaseHorizontalActive)
                {
                    KeyBaseActiveControl(ref Horizontal, PositiveHorizontalKeyCode, NegativeHorizontalKeyCode);
                }
                if(_keyBaseVerticalActive)
                {
                    KeyBaseActiveControl(ref Horizontal, PositiveVerticalKeyCode, NegativeVerticalKeyCode);
                }
            }

        }

        private void KeyBaseActiveControl(ref float value, KeyCode positive, KeyCode negative)
        {
            bool positiveActive = Input.GetKey(positive);
            bool negativeActive = Input.GetKey(negative);

            if (positiveActive)
            {
                value +=  _increaseAmount;
            }
            else if (negativeActive)
            {
                value -= _increaseAmount;
            }
            else
            {
                value = 0;
            }

            value = Mathf.Clamp(value, -1, 1);
        }

    }
}