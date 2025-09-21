using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject gameoverPannel, PausePannel, ScorePannel, pauseButtonPannel;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverScoreText;
    public TextMeshProUGUI bestScoreText;

    private int score;
    private int bestScore;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else { Destroy(gameObject); return; }
    }

    void Start()
    {
        Time.timeScale = 1;
        PausePannel.SetActive(false);
        pauseButtonPannel.SetActive(true);
        ScorePannel.SetActive(true);
        score = 0;
        bestScore = PlayerPrefs.GetInt("BestScore", 0);
        UpdateScoreUI();
    }

    public void IncreaseScore()
    {
        score++;
        UpdateScoreUI();
        Debug.Log("IncreaseScore: " + score);
    }

    void UpdateScoreUI()
    {
        if (scoreText != null) scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        gameoverPannel.SetActive(true);
        Time.timeScale = 0;
        pauseButtonPannel.SetActive(false);
        ScorePannel.SetActive(false);

        if (gameOverScoreText != null)
            gameOverScoreText.text = "Score = " + score.ToString();

        if (score > bestScore)
        {
            bestScore = score;
            PlayerPrefs.SetInt("BestScore", bestScore);
        }

        if (bestScoreText != null)
            bestScoreText.text = "Best Score = " + bestScore.ToString();
    }


    public void PouseButtonPressed()
    {
        PausePannel.SetActive(true);
        Time.timeScale = 0;
    }

    public void PouseBackButtonPressed()
    {
        PausePannel.SetActive(false);
        Time.timeScale = 1;
    }
}
