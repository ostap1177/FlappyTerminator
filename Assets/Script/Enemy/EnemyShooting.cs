using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : Shooting
{
    [SerializeField] private float _secondBetweenShot;

    private float _elepsedTime;

    private void Update()
    {
        _elepsedTime += Time.deltaTime;

        if (_elepsedTime > _secondBetweenShot)
        {
            _elepsedTime = 0;

            Shoot();
        }
    }
}
