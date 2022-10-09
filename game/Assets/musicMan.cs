using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicMan : MonoBehaviour
{
    private AudioSource audioS;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        audioS = GetComponent<AudioSource>();

        if (GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>().isPlaying)
        {
            Destroy(this);
        }
        else
        {
            PlayMusic();
        }
    }

    public void PlayMusic()
    {
        if (audioS.isPlaying) return;
        audioS.Play();
    }

    public void StopMusic()
    {
        audioS.Stop();
    }
}
