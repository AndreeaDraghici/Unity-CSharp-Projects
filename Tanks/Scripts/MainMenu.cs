using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Slider Volume;
    private AudioSource sound;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OptionsGame()
    {
        //use this for initialization
        sound = GetComponent<AudioSource>();
        //to set volume from slider
        sound.volume = Volume.value;
    }

    public void ExitGame()
    {
        Debug.Log("EXIT!");
        Application.Quit();
    }
}
