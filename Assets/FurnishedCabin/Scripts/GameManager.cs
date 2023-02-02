using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Start()
    {
        
    }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(transform.root);
        }
    }
    public void ViewGame()
    {
        //load the game scene

    }
    public void ResumeGame()
    {

    }

    public void PauseGame()
    {

    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
