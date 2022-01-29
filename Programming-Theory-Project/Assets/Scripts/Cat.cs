using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal //INHERITANCE
{
    /*
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Walk();
        }
    }
    */

    public override void Jump() // POLYMORPHISM
    {
        animalRb.AddForce((transform.up) * jumpheight * 2, ForceMode.Impulse);
    }
}
