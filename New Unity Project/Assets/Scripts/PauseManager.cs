using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseCanvas;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseCanvas.activeSelf)
            {
                pauseCanvas.SetActive(false);
                Time.timeScale = 1;
                Cursor.visible = false;
            }

            else if (!pauseCanvas.activeSelf)
            {
                pauseCanvas.SetActive(true);
                Time.timeScale = 0;
                Cursor.visible = true;
            }

        }
    }

    public void Resume()
    {
        pauseCanvas.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void BackToMenu()
    {
        Time.timeScale = 1;
        Cursor.visible = true;
        SceneManager.LoadScene(0);
    }
}
