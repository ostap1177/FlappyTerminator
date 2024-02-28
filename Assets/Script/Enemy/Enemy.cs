using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Bullet bullet) == true)
        {
            Die();
        }
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
