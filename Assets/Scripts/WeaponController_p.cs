using System.Collections.Generic;
using UnityEngine;

public class WeaponController_p : MonoBehaviour {

    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;

    private int poolSize;
    private int bulletCount;
    public List<GameObject> bulletPool;


	void Start ()
    {
        poolSize = 20;

        for ( int i =0; i< poolSize; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.SetActive(false);
            bulletPool.Add(bullet);
        }
	}
	

	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) Fire();
	}

    private void Fire()
    {
        if (bulletCount < poolSize - 1)

            Destroy(bullet, 2.0f);
        {
            bulletPool[bulletCount].transform.position = bulletSpawnPoint.position;
            bulletPool[bulletCount].SetActive(true);
            bulletCount++;
        }

        if (bulletCount == poolSize - 1)
        {
            bulletPool[bulletCount].transform.position = bulletSpawnPoint.position;
            bulletPool[bulletCount].SetActive(true);
            bulletCount = 0;
        }
    }

}
