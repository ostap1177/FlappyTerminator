using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private EnemySpawner _enemySpawner;
    [SerializeField] private StartScreen _startScreen;
    [SerializeField] private EndScreen _gameOverScreen;

    private void OnEnable()
    {
        _startScreen.PlayButtonClicked += OnPlayButtonClick;
        _gameOverScreen.RestartButtonClicked += OnRestartButtonClick;
        _player.GameOver += OnGameOver;
    }

    private void OnDisable()
    {
        _startScreen.PlayButtonClicked -= OnPlayButtonClick;
        _gameOverScreen.RestartButtonClicked -= OnRestartButtonClick;
        _player.GameOver -= OnGameOver;
    }

    private void Start()
    {
        Time.timeScale = 0;
        _startScreen.Open();
    }

    private void OnPlayButtonClick()
    {
        _startScreen.Close();
        StartGame();
    }


    private void OnRestartButtonClick()
    {
        _gameOverScreen.Close();
        _enemySpawner.ResetPoll();
        StartGame();
    }

    private void StartGame()
    {
        Time.timeScale = 1;
        _player.ResetPlayer();
    }

    public void OnGameOver()
    {
        Time.timeScale = 0;
        _gameOverScreen.Open();
    }
}
