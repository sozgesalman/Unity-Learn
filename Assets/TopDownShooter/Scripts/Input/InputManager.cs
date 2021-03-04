using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerInput
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private InputData[] _inputDataArray;

       /// [SerializeField] private InputData _rotationInputData;
        ///private Vector3 _LastMousePosition;

        private void Update()
        {
            for(int i = 0; i < _inputDataArray.Length; i++)
            {
                _inputDataArray[i].ProcessInput();
            }
            //_inputData.Horizontal = Input.GetAxis("Horizontal") ;
            //_inputData.Vertical = Input.GetAxis("Vertical");

            //_rotationInputData.Horizontal = (Input.mousePosition.x - _LastMousePosition.x);
            //_LastMousePosition = Input.mousePosition;

        }
    }
}
