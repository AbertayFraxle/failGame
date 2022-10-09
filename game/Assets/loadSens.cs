using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadSens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<CinemachineFreeLook>().m_YAxis.m_MaxSpeed = (PlayerPrefs.GetFloat("sensitivity", 0.5f) * 19 ) +1;
        this.GetComponent<CinemachineFreeLook>().m_XAxis.m_MaxSpeed = (PlayerPrefs.GetFloat("sensitivity", 0.5f) * 1240) + 60;
    }

    
}
