using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Drawing;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject gameoverPannel, PausePannel, pauseButtonPannel;
    public TextMeshPro worldScoreText;
    private int score;
    private int bestScore;
    public TextMeshProUGUI gameOverScoreText; 
    public TextMeshProUGUI bestScoreText;
    public AudioSource Die, flap, point,click;


    void Awake()
    {
        if (Instance == null) Instance = this;
        else { Destroy(gameObject); return; }
        flap.Play();
    }

    void Start()
    {
        Time.timeScale = 1;
        PausePannel.SetActive(false);
        pauseButtonPannel.SetActive(true);

        score = 0;
        bestScore = PlayerPrefs.GetInt("BestScore", 0);
        UpdateScoreUI();
    }

    public void IncreaseScore()
    {
        score++;
        UpdateScoreUI();
        Debug.Log("IncreaseScore: " + score);
        point.Play();
    }

    private void UpdateScoreUI()
    {
        if (worldScoreText != null)
            worldScoreText.text = score.ToString();
    }

    public int Score => score;
    public void GameOver()
    {
        Die.Play();
        flap.Stop();
        gameoverPannel.SetActive(true);
        Time.timeScale = 0;
        pauseButtonPannel.SetActive(false);

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
        flap.Stop();
        PausePannel.SetActive(true);
        Time.timeScale = 0;
        click.Play();
    }

    public void PouseBackButtonPressed()
    {
        PausePannel.SetActive(false);
     click.Play();
        Time.timeScale = 1;
        flap.Play();
    }
}
