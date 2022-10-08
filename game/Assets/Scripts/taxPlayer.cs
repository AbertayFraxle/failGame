using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taxPlayer : MonoBehaviour
{
    [SerializeField]
    public int gateCost;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider player)
    {
        if (player.GetComponent<coinManage>().checkCoins() >= gateCost)
        {
            player.GetComponent<coinManage>().removeCoins(gateCost);
            this.gameObject.SetActive(false);
        }
    }
}