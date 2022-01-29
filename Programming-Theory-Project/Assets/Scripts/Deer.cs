using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deer : Animal //INHERITANCE
{

    public override void Jump() // POLYMORPHISM
    {
        animalRb.AddForce(transform.up * jumpheight * 1.5f, ForceMode.Impulse);
    }
}
