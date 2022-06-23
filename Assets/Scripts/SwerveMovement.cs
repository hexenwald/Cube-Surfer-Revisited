using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveMovement : MonoBehaviour
{
    [SerializeField] private float _swerveSpeed = 0.5f;
    // [SerializeField] private float _maxSwerveAmount = 1f;

    private SwerveInputSystem _swerveInputSystem;

    private void Awake()
    {
        _swerveInputSystem = GetComponent<SwerveInputSystem>();
    }

    private void Update()
    {
        float swerveAmount = Time.deltaTime * _swerveSpeed * _swerveInputSystem.MoveFactorX;
        // swerveAmount = Mathf.Clamp(swerveAmount, -_maxSwerveAmount, _maxSwerveAmount);
        transform.Translate(swerveAmount, 0, 0);
    }
}
