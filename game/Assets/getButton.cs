using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class getButton : MonoBehaviour
{
    private void Start()
    {
        buttonUnlock();
    }

    public void buttonUnlock()
    {
        int unlockedTo = PlayerPrefs.GetInt("unlocked", 1);
        


        for (int i = 0; i< unlockedTo; i++)
        {

            Transform button = transform.GetChild(i);

            button.GetComponent<Image>().color = new Color(12, 103, 53);
            button.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Level " + (i + 1);

  
        }
    }

    public void loadLevel1()
    {
        if (PlayerPrefs.GetInt("unlocked", 1) >= 1) {
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
    }
    public void loadLevel2()
    {
        if (PlayerPrefs.GetInt("unlocked", 1) >= 2)
        {
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        }
    }
    public void loadLevel3()
    {
        if (PlayerPrefs.GetInt("unlocked", 1) >= 3)
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
    }
    public void loadLevel4()
    {
        if (PlayerPrefs.GetInt("unlocked", 1) >= 4)
        {
            SceneManager.LoadScene(4, LoadSceneMode.Single);
        }
    }
    public void loadLevel5()
    {
        if (PlayerPrefs.GetInt("unlocked", 1) >= 5)
        {
            SceneManager.LoadScene(5, LoadSceneMode.Single);
        }
    }
    public void loadLevel6()
    {
        if (PlayerPrefs.GetInt("unlocked", 1) >= 6)
        {
            SceneManager.LoadScene(6, LoadSceneMode.Single);
        }
    }
    public void loadLevel7()
    {
        if (PlayerPrefs.GetInt("unlocked", 1) >= 7)
        {
            SceneManager.LoadScene(7, LoadSceneMode.Single);
        }
    }
    public void loadLevel8()
    {
        if (PlayerPrefs.GetInt("unlocked", 1) >= 8)
        {
            SceneManager.LoadScene(8, LoadSceneMode.Single);
        }
    }

}

