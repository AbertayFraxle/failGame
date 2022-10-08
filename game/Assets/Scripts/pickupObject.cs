using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupObject : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<bootPower>() != null)
        {
            other.GetComponent<bootPower>().giveBoots();
            this.gameObject.SetActive(false);
        }
    }
}
