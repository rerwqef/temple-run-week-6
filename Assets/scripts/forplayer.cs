using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class forplayer : MonoBehaviour
{



    public AudioSource clip;
   
    public Animator animator;
    public bool jumb = false;
    public bool slide = false;
    public bool altrajumb;
    public int coinvalue;
    GameObject trigger;
    public float scorecorrct;
    public GameObject gameover;
    //public float v = 0.3f;
    // public Rigidbody rb;
    CharacterController characterController;
    [Header("Player Statistics")] // Title
    [Tooltip("Adjust the speed of the player.")] // Show information on mouse hover
    public float runningSpeed = 20f;
    public float turnspeed=10f;
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
        animator = animator.GetComponent<Animator>();
         scorecorrct = transform.position.z;
      
    }

    void Update()
    {
     
        Vector3 jumpVelocity = Vector3.up * 10;

        Vector3 movement = Vector3.zero;
            movement.z = runningSpeed * Time.deltaTime;
            movement.y = -2f * Time.deltaTime;
            if (Input.GetKey(KeyCode.A))
            {
                movement.x = -turnspeed * Time.deltaTime;

            }
            else if (Input.GetKey(KeyCode.D))
            {
                movement.x = turnspeed * Time.deltaTime;


            }
            characterController.Move(movement);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                altrajumb = true;
            
            }
            else
            {
                altrajumb = false;
            }

            scorecorrct += movement.z;


            if (Input.GetKeyDown(KeyCode.W))
            {
                jumb = true;
            }
            else
            {
                jumb = false;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                slide = true;
            }
            else
            {
                slide = false;
            }

            if (jumb)
            {
                animator.SetBool("isjumb", jumb);
           // transform.Translate(Vector3.up * 10 * Time.deltaTime);
            movement.y = 20f * Time.deltaTime;
            }
            else if (!jumb)
            {
                animator.SetBool("isjumb", jumb);
               
            }
            if (slide)
            {
                animator.SetBool("isslide", slide);

                movement.z = runningSpeed +10f* Time.deltaTime;
            }
            else if (!slide)
            {
                animator.SetBool("isslide", slide);
                movement.z = runningSpeed * Time.deltaTime;
            }
     //  if(Input.GetKeyDown(KeyCode.M)) {
       //     characterController.Move(Vector3.up * 50f*Time.deltaTime);
     //   }

        if (altrajumb)
            {
                animator.SetBool("altrajumb", altrajumb);

            // jumpHeight is the desired jump height
           
        }
            else if (!altrajumb)
            {
                animator.SetBool("altrajumb", altrajumb);
               
            }
            trigger = GameObject.FindGameObjectWithTag("m");
            /*    Vector3 rayOrigin = transform.position;
                Vector3 rayDirection = transform.forward;
                RaycastHit hit;

                if (Physics.Raycast(rayOrigin, rayDirection, out hit, interactionDistance))
                {
                    if (hit.collider.CompareTag("brick"))
                    {
                        // Handle the trigger interaction with the brick
                        Debug.Log("Trigger interaction with brick");
                        // You can add more logic here
                    }
                }*/
        
    }

    /* private void OnCollisionEnter(Collision collision)
     {
         if (collision.collider.tag == "ender")
         {
             Debug.Log("hai");
         }
     }*/
    //  public void OnControllerColliderHit(ControllerColliderHit hit)
    //   {
    //      if (hit.gameObject.CompareTag("brick"))
    /// <summary>
    ///     {
    //// </summary>
    /// <param name=""></param>
    //     Destroy(hit.gameObject);


    //  }
    // }
  
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("coin"))
        {
            //clip.Play();
            Destroy(other.gameObject);
            coinvalue++;
            

        }
        GameObject supporter = GameObject.FindGameObjectWithTag("sup");
        if (other.CompareTag("l"))
        {
            Destroy(supporter.gameObject);
        }
    }
   
    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.CompareTag("ender"))
        {
            Time.timeScale = 0;
            gameover.SetActive(true);
            clip.Stop();
        }
    }
  
    

}
