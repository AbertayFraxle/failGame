using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bootPower : MonoBehaviour
{

    [SerializeField]
    public GameObject boots;

    // Start is called before the first frame update
    void Start()
    {
        boots.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
