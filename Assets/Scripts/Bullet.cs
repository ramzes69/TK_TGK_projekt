using UnityEngine;

public class Bullet : MonoBehaviour {
    
    [Range(0,20)]
    public int bulletSpeed;

	void Update ()
    {
        transform.Translate(Vector3.one * Time.deltaTime * bulletSpeed);

    }
}
