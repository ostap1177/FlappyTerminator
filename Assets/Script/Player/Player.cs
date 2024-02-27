using UnityEngine;

[RequireComponent(typeof(PlayerMover))]
public class Player : MonoBehaviour
{
    private PlayerMover _playerMover;
    private int _score;

    private void Awake()
    {
        _playerMover = GetComponent<PlayerMover>();
    }

    public void ResetPlayer()
    {
        _score = 0;
        _playerMover.ResetPlayer();
    }

    public void Die()
    {
        Time.timeScale = 0;
    }
}
