using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject pauseCanvas;

    bool isPaused;

    private void Start()
    {
        isPaused = false;
    }
    private void Update()
    {
        //escape key is pressed
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            isPaused=!isPaused;
        }

        //no button function
        if(isPaused)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
            pauseCanvas.SetActive(true);
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
            pauseCanvas.SetActive(false);
        }
    }
    public void MainMenu()
    {
        //load the main menu scene
        SceneManager.LoadScene(0);
    }

    public void ResumeGame() //set onclick button
    {
        isPaused = false;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
