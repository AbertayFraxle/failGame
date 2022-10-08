using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class manageUI : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI lives;

    [SerializeField]
    public TextMeshProUGUI coins;

    [SerializeField]
    public Transform player;


    // Update is called once per frame
    void Update()
    {
        lives.text = "x" + (player.GetComponent<playerDie>().lives+1);

        coins.text = player.GetComponent<coinManage>().checkCoins().ToString();
    }
}
