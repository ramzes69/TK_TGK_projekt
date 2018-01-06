using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCont : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public int forceConst = 30;

    private Rigidbody selfRigidbody;
    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

    }
}
