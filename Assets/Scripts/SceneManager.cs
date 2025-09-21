using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public AudioSource ButtonPressSound;
    public void ReloadCurrentScene()
    {
        ButtonPressSound.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void QuitGame()
    {
        Application.Quit();
        ButtonPressSound.Play();
    }
    public void LoadHomeScreen()
    { ButtonPressSound.Play();
        SceneManager.LoadScene("HomeScene");
       
    }
}
