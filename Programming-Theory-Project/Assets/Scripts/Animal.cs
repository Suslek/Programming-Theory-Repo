using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public string animalName;
    public float speed;
    public float jumpheight;
    public Rigidbody animalRb { get; set; } //ENCAPSULATION

    public void Start()
    {
        animalRb = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Walk();
        }
    }

    public virtual void Jump() //ABSTRACTION
    {
        animalRb.AddForce(transform.up * jumpheight, ForceMode.Impulse);
    }

    public virtual void Walk()//ABSTRACTION
    {
        animalRb.AddForce(transform.right * speed,ForceMode.Acceleration);
    }
}
