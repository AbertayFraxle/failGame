using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void onPlayClick()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void onSettingsClick()
    {

    }

    public void onQuitClick()
    {
        Application.Quit();
    }

}
