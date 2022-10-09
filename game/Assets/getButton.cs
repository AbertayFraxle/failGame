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
            
            if (button.GetComponent<Image>() != null)
            {
                button.GetComponent<Image>().color = new Color(12, 103, 53);
                button.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Level " + (i + 1);
                button.GetComponent<Button>().onClick.AddListener(delegate { loadLevel(i); });
            }
        }
    }

    public void loadLevel(int index)
    {
        SceneManager.LoadScene(index, LoadSceneMode.Single);
    }

}

