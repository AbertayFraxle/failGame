using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinItem : MonoBehaviour
{

    float angle = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        angle += 60 * Time.deltaTime;
        transform.rotation = Quaternion.Euler(new Vector3(0, angle, 0));
    }
}
