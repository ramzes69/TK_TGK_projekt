using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poruszanie1 : MonoBehaviour
{

    public float speed;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal1 = Input.GetAxis("Horizontal1");
        float moveVertical1 = Input.GetAxis("Vertical1");


        Vector3 movement = new Vector3(moveHorizontal1, 0.0f, moveVertical1);
        rb.AddForce(movement * speed);
    }
}
