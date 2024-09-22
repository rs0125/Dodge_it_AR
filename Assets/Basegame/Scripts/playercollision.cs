using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement move;
    public Rigidbody rb;
    int backwardforce = 1;

    int count = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            count += 1;
            rb.AddForce(0, 0, -backwardforce, ForceMode.VelocityChange);

        }

        if (count >= 4)
        {
            move.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
