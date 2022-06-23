using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveInputSystem : MonoBehaviour
{
    private float _lastFingerPosX;
    private float _moveFactorX;
    public float MoveFactorX => _moveFactorX;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _lastFingerPosX = Input.mousePosition.x;
        }
        else if (Input.GetKey(KeyCode.Mouse0))
        {
            _moveFactorX = Input.mousePosition.x - _lastFingerPosX;
            _lastFingerPosX = Input.mousePosition.x;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            _moveFactorX = 0f;
        }
    }
}
