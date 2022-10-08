using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtCamera : MonoBehaviour
{
    public Transform cam;
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(cam);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(cam, Vector3.up);
    }
}
