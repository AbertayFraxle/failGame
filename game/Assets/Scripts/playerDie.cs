using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDie : MonoBehaviour
{
    public int lives = 3;
    public CharacterController controller;
    public GameObject corpse;

    [SerializeField]
    public GameObject pickupMan;

    private void Update()
    {
        if (controller.transform.position.y < -20)
        {
            if (lives > 0)
            {
                --lives;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    private void OnTriggerEnter(Collider hitObj)
    {
        if (hitObj.gameObject.layer == 6) //Death layer
        {
            Debug.Log("HIT");
            float yRot = controller.transform.eulerAngles.y;
            Quaternion initialRot = Quaternion.Euler(-90f, yRot, 0f);
            if (lives > 0)
            {
                Instantiate(corpse, controller.transform.position, Quaternion.identity * initialRot);
                --lives;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

            controller.enabled = false;
            controller.transform.position = new Vector3(1, 1, 1);
            controller.enabled = true;

            this.GetComponent<bootPower>().removeBoots();
            pickupMan.GetComponent<reloadObjects>().trigger();
        }
    }
}
