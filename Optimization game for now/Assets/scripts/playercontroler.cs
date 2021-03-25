using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playercontroler : MonoBehaviour
{
   public float speed = 6.0F;
     public float jumpSpeed = 8.0F; 
     public float gravity = 20.0F;
     private Vector3 moveDirection = Vector3.zero;
     private float turner;
     private float looker;
     public float sensitivity;
     public Text TextScore;
    public static int score = 0;
 
     // Use this for initialization
     void Start () {
         score = 0;
     }
     
     // Update is called once per frame
     void Update () {
         CharacterController controller = GetComponent<CharacterController>();
         
        

         if (controller.isGrounded) {
             
             moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
             moveDirection = transform.TransformDirection(moveDirection);
            
             moveDirection *= speed;
            
             if (Input.GetButton("Jump"))
                 moveDirection.y = jumpSpeed;
 
         }
         
        
         moveDirection.y -= gravity * Time.deltaTime;
        
         controller.Move(moveDirection * Time.deltaTime);
        
         if (Input. GetKey ("escape")) {
           Application. Quit();
           Debug.Log("Exited game");
        }
         TextScore.text = "Score: " + score;
     }

      private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("pickup"))
        {
            score += 1;
           Destroy(other.gameObject);
            if (score >= 3)
            {
                SceneManager.LoadScene("Win");
            }
        }

    }
}
