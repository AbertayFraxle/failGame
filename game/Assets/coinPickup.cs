using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinPickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<coinManage>().addCoin();
        this.gameObject.SetActive(false);
    }
}
