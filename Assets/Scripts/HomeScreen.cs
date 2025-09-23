using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeScreen : MonoBehaviour
{
    [SerializeField] GameObject LevelsPanel;
    public void StartButtonPressed()
    {
        LevelsPanel.SetActive(true);
    }
    public void QuitButtonPressed()
    {
        Application.Quit();
    }
    

}
