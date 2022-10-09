using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class renderSetup : MonoBehaviour
{
    [SerializeField]
    public RenderTexture targ;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Camera>().targetTexture = targ;
    }

    
}
