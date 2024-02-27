using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Die();
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
