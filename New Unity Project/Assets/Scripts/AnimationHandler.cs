using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    public bool Throw = false;
    public Animator Ani;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Throw = true;
            //Shows In Editor Throw Is True
            Ani.SetBool("Throwing", true);
            //Sets The Animation Parameter To True
            Debug.Log("W Key Is Pressed");
            //Checks For Keypress!
        }
        else
        {
            Throw = false;
            //Shows in Editor Throw Is False
             Ani.SetBool("Throwing", false);
            //Sets The Animation Parametor To False

        }
    }
}
