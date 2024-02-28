using System;
using UnityEngine;

[RequireComponent(typeof(PlayerMover))]
[RequireComponent(typeof(PlayerCollisionHandler))]
public class Player : MonoBehaviour
{
    private PlayerMover _playerMover;
    private PlayerCollisionHandler _handler;
    private int _score;

    public event Action GameOver;

    private void Awake()
    {
        _playerMover = GetComponent<PlayerMover>();
        _handler = GetComponent<PlayerCollisionHandler>();
        ResetPlayer();
    }

    public void ResetPlayer()
    {
        _score = 0;
        _playerMover.ResetPlayer();
    }

    public void Die()
    {
        Time.timeScale = 0;
        GameOver?.Invoke();
    }
}
