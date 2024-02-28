using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float _delay = 0.05f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject, _delay);
    }
}
