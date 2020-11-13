using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public GameObject ball;
    public Rigidbody rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb.useGravity = false;
        rb = GetComponent<Rigidbody>();
        //Disables Gravity

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Collide")
        {
            ball.transform.SetParent(null);
            //Deparents Ball
            rb.useGravity = true;
            //Adds Gravity
            Debug.Log("Throws Ball!");
        }
    }
}
