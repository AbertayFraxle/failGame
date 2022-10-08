using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reloadObjects : MonoBehaviour
{
    public void trigger()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(true);
        }
    }
}
