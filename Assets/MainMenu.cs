using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
    public Canvas menu;
     bool MainMenuIsOpen;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MainMenuIsOpen = !MainMenuIsOpen;

            if (MainMenuIsOpen)
            {
                menu.enabled = true;
                Time.timeScale = 0;
            }
            if (!MainMenuIsOpen)
            {
                menu.enabled = false;
                Time.timeScale = 1;
            }
        }
    }   

    public void PlayGame()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

    public void QuitMenu() 
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    
}