using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour {
    
    [Range(0,20)]
    public int bulletSpeed;
    

	void Update ()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * bulletSpeed, Space.Self );
    }
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(0);
    }
}
