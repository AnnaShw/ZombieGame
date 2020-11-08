using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AllButtons : MonoBehaviour
{
    public Slider musicS;
    GameObject GController;
    void Awake()
    {
        GController = GameObject.Find("MenuController");
        if (GController == null) return;
        AudioSource music = GameObject.Find("MenuController").GetComponent<AudioSource>();
        musicS.value = music.volume;
    }

    public void ExitScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("GameLevel");
    }
    public void ChanngeVolume(float volume)
    {
        if (GController == null) return;
        AudioSource music = GameObject.Find("MenuController").GetComponent<AudioSource>();
        music.volume = volume;
    }
}
