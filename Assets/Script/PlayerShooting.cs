using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : Shooting
{
    [SerializeField] private KeyCode _shootKey;

    private void Update()
    {
        if (Input.GetKeyDown(_shootKey) == true)
        {
            Shoot();
        }
    }
}
