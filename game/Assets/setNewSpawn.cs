using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setNewSpawn : MonoBehaviour
{
    public Transform player;
    public Transform spawn;

    // Update is called once per frame
    void Update()
    {
        float dis = Vector3.Distance(transform.position, player.transform.position);
        if (dis < 5f)
        {
            spawn.transform.position = player.transform.position;
        }
    }
}
