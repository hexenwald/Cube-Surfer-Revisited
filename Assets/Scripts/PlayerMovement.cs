using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _maxSwerve = 1f;
    //[SerializeField] float _turnSpeed;

    private float _horizontalMovement;
    private bool _isMoving = false;

    void Update()
    {
        /* movement for the prototype
        _horizontalMovement = Input.GetAxis("Horizontal") * _turnSpeed * Time.deltaTime; 

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _isMoving = true;
        }
        if (_isMoving == true)
        {
            this.transform.Translate(_horizontalMovement, 0, _movementSpeed * Time.deltaTime);
        } */

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _isMoving = true;
        }

        if (_isMoving == true)
        {
            this.transform.Translate(0, 0, _movementSpeed * Time.deltaTime);
        }

        MaxSwerveLimit();
    }

    private void MaxSwerveLimit()
    {
        var pos = transform.position;
        pos.x = Mathf.Clamp(transform.position.x, -_maxSwerve, _maxSwerve);
        transform.position = pos;
    }
}