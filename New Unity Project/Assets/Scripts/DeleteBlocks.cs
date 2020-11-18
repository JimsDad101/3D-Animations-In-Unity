using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBlocks : MonoBehaviour
{

    public GameObject block;

    // Start is called before the first frame update
    private void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Sphere")
        {
            Debug.Log("Collision On White Block");
            // Checks Collision Against The Wall
            Destroy(gameObject);
            // Destroys The White Block
        }
    }
}
