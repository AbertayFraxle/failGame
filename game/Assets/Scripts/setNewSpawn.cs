using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setNewSpawn : MonoBehaviour
{
    public Transform player;
    public Transform spawn;
    public Transform flag;
    private bool grabbed = false;
    float yPos = -0.2f;

    // Update is called once per frame
    void Update()
    {
        float dis = Vector3.Distance(transform.position, player.transform.position);
        if (dis < 5f)
        {
            grabbed = true;
            spawn.transform.position = player.transform.position;
        }

        if(grabbed == true)
        {
            if (yPos <= 0.3)
            {
                yPos += 1f * Time.deltaTime;
                flag.transform.localPosition = new Vector3(3.35f, yPos, -0.03f);
            }
        }

    }
}
