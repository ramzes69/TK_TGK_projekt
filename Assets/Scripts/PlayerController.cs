using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayerController : MonoBehaviour {
    //private object count;
    public float speed;
    public Text countText;
    public Text winText;
  

    private Rigidbody rb;
    private bool isGrounding;
    private int count;

    public int forceConst = 30;

    private bool canJump;
    private Rigidbody selfRigidbody;



    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        winText.text = "";

    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            canJump = true;
        }
    }

    void FixedUpdate ()
    {
        if (canJump)
        {
            canJump = false;
            selfRigidbody.AddForce(0f, forceConst, 0f, ForceMode.Impulse);
        }
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
  
        
    }

    void SetCountText ()
    {

        countText.text = "Wynik: " + count.ToString();
        if (count >= 12)
        {
            winText.text = "Wygrana!";

        }
    }
}
//Destroy(other.gameObject);
//if (other.gameObject.CompareTag("Player"))
// gameObject.SetActive(false);