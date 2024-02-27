using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    private float _delay=0.05f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Enemy enemy) == true)
        {
            enemy.Die();
        }

        if (collision.TryGetComponent(out Player player) == true)
        {
            player.Die();
        }
    }
}
