using UnityEngine;

public class Bullet : MonoBehaviour {
    
    [Range(0,20)]
    public int bulletSpeed;

	void Update ()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * bulletSpeed, Space.Self );
    }
}
