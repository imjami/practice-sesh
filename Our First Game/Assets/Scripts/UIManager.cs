using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        _birdSprite.color = Color.green;
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
        _birdScript.IsAlive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
