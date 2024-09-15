using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class movement : MonoBehaviour
{

    public Rigidbody rb;
    public float ForwardForce = 2000f;
    public float KeySideForce = 500f;
    public float ButtonSideForce = 500f;
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
            rb.AddForce(transform.right*ButtonSideForce * Time.deltaTime);
        }


        if (left.isPressed)
        {
            rb.AddForce(-transform.right * ButtonSideForce * Time.deltaTime);
        }



        if (Input.GetKey("d"))
        {
            rb.AddForce(KeySideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-KeySideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        if (transform.localPosition.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
