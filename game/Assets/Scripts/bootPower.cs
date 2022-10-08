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
        boots.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void giveBoots()
    {
        boots.SetActive(true);
        this.GetComponent<playerMove>().jumpHeight = 9f;
    }

    public void removeBoots()
    {
        boots.SetActive(false);
        this.GetComponent<playerMove>().jumpHeight = 3f;
    }
}
