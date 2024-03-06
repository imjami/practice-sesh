using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject _bird;
    [SerializeField] TextMeshProUGUI _score;
    [SerializeField] Canvas _gameOverUI;
    [SerializeField] PipeSpawner _spawner;

    int _scoreNum = 0;
    SpriteRenderer _birdSprite;
    BirdController _birdScript;

    private void Awake()
    {
        _birdSprite = _bird.GetComponent<SpriteRenderer>();
        _birdScript = _bird.GetComponent<BirdController>();
    }

    void Start()
    {
        UpdateScoreText();
        _gameOverUI.enabled = false;
    }

    private void Update()
    {
        if (PipeCollision.IsGameOver) GameOver();
    }

    public void AddScore(int numToAdd)
    {
        _scoreNum += numToAdd;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        _score.text = _scoreNum.ToString();
    }

    void GameOver()
    {
        _gameOverUI.enabled = true;
        _birdSprite.color = Color.red;
        StopScripts();
    }


    void StopScripts()
    {
        PipeMover.IsGameOver = true;
        _birdScript.enabled = false;
        _spawner.IsGameOver = true;
    }
}
