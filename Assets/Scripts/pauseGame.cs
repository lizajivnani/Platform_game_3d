using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseGame : MonoBehaviour
{

    public AudioSource pauseAudio;
    public GameObject pauseMenu;
    public bool gamePaused = false;
    public AudioSource levelMusic;

    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            if(gamePaused == false)
            {
                pauseAudio.Play();
                Time.timeScale = 0;
                gamePaused = true;
                Cursor.visible = true;
                levelMusic.Pause();
                gem_rotate.rotate_speed = 0;
                pauseMenu.SetActive(true);
            }

            else
            {
                Time.timeScale = 1;
                gamePaused = false;
                Cursor.visible = false;
                levelMusic.UnPause();
                gem_rotate.rotate_speed = 1;
                pauseMenu.SetActive(false);


            }
        }
        
    }


    public void resumeGame()
    {
        Time.timeScale = 1;
        gamePaused = false;
        Cursor.visible = false;
        levelMusic.UnPause();
        gem_rotate.rotate_speed = 1;
        pauseMenu.SetActive(false);


    }

    public void restartLevel()
    {
        SceneManager.LoadScene(2);

    }

    public void returnToMenu ()
    {
        SceneManager.LoadScene(1);

    }
}
