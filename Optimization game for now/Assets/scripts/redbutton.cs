using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redbutton : MonoBehaviour
{
       public GameObject Redwall;
       public GameObject Redwall2;
       public GameObject wall;
       public GameObject wall1;
       public GameObject wall2;
       public GameObject wall3;

     void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
         Redwall.SetActive(false);
         Redwall2.SetActive(false);
         wall.SetActive(true);
         wall1.SetActive(true);
         wall2.SetActive(true);
         wall3.SetActive(true);
        }
    }
}
