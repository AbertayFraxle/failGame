using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDie : MonoBehaviour
{
    public Transform killCheck;
    public float killDis = 1f;  //ground distance you twat
    public LayerMask killMask;
    public CharacterController controller;
    public GameObject corpse;

    [SerializeField]
    public GameObject pickupMan;

    // Update is called once per frame
    /*  void Update()
      {
           shouldDie = Physics.CheckSphere(killCheck.position, killDis, killMask);

          if(shouldDie == true)
          {
              
          }
      }*/

    private void OnTriggerEnter(Collider hitObj)
    {
        if (hitObj.gameObject.layer == 6) //Death layer
        {
            Debug.Log("HIT");
            float yRot = controller.transform.eulerAngles.y;
            Quaternion initialRot = Quaternion.Euler(-90f, yRot, 0f);
            Instantiate(corpse, controller.transform.position, Quaternion.identity * initialRot);

            controller.enabled = false;
            controller.transform.position = new Vector3(1, 1, 1);
            controller.enabled = true;

            this.GetComponent<bootPower>().removeBoots();
            pickupMan.GetComponent<reloadObjects>().trigger();
        }
    }
}
