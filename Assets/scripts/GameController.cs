using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject TaptoStart;
    public GameObject ScoreText;
    public AudioSource Interface;
    // Start is called before the first frame update
    public void Start()
    {
       
        gameOverPanel.SetActive(false);
        PauseGame();
        ScoreText.SetActive(false);
    }
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartGame();
            TaptoStart.SetActive(false);
            ScoreText.SetActive(true);
        }
    }
    public void GameOver()

    {
        gameOverPanel.SetActive(true);
        ScoreText.SetActive(false);
    }
    public void Restart()
    {
        SceneManager.LoadScene("MainScene");
        Interface.Play();
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("game quitted");
        Interface.Play();
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        Time.timeScale = 1f;
        
    }
}
