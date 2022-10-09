using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField]
    public Canvas main;

    [SerializeField]
    public Canvas settings;

    [SerializeField]
    public Slider gameVolume;

    [SerializeField]
    public Slider musicVolume;

    [SerializeField]
    public Slider sensitivity;

    private void Start()
    {
        LoadMenu();

        gameVolume.value = 0;
        musicVolume.value = PlayerPrefs.GetFloat("musicVolume", 1);
        sensitivity.value = PlayerPrefs.GetFloat("sensitivity", 0.5f);
    }

    public void onPlayClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
    }

    public void onSettingsClick()
    {
        main.gameObject.SetActive(false);
        settings.gameObject.SetActive(true);
    }

    public void onQuitClick()
    {
        Application.Quit();
    }

    public void onGVolumeChange()
    {
        //PlayerPrefs.SetFloat("gameVolume", gameVolume.value);
        gameVolume.value = 0;
    }

    public void onMVolumeChange()
    {

        PlayerPrefs.SetFloat("musicVolume", musicVolume.value);

        GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>().volume = musicVolume.value;
    }

    public void onSensChange()
    {
        PlayerPrefs.SetFloat("sensitivity", sensitivity.value);
    }

    public void LoadMenu()
    {
        main.gameObject.SetActive(true);
        settings.gameObject.SetActive(false);
    }
}
