using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float ForwardForce = 50f;
    public float SideForce = 50f;
    public MyButton left;
    public MyButton right;


    private void Start()
    {
       // ObjectSpawner.heyIamalivebtw();
    }
    // Update is called once per frame
    void FixedUpdate()
    {   
        //adds a forward force
        rb.AddForce(transform.forward* ForwardForce * Time.deltaTime);

        if (right.isPressed)
        {
            rb.AddForce(transform.right* SideForce * Time.deltaTime);
        }


        if (left.isPressed)
        {
            rb.AddForce(-transform.right * SideForce * Time.deltaTime);
        }



        if (Input.GetKey("d"))
        {
            rb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        if (transform.localPosition.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
