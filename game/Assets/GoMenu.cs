using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoMenu : MonoBehaviour
{
    // Start is called before the first frame update

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void go()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
