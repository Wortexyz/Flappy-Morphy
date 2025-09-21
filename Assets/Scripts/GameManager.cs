using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject gameoverPannel,PausePannel,ScorePannel,pauseButtonPannel;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        PausePannel.SetActive(false);
        pauseButtonPannel.SetActive(true);
        ScorePannel.SetActive(true);
    }

    // Update is called once per frame
    public void GameOver()
    {
        gameoverPannel.SetActive(true);
        Time.timeScale = 0;
        pauseButtonPannel.SetActive(false);
        ScorePannel.SetActive(false);
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


