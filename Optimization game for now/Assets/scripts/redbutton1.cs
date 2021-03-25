using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redbutton1 : MonoBehaviour
{
       public GameObject Redwall;
       public GameObject Redwall2;
       public GameObject Redwall3;
       public GameObject Redwall4;
       public GameObject Redwall5;
       public GameObject wall;

     void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
         Redwall.SetActive(false);
         Redwall2.SetActive(false);
         Redwall3.SetActive(false);
         Redwall4.SetActive(false);
         Redwall5.SetActive(false);
         wall.SetActive(true);
        }
    }
}
