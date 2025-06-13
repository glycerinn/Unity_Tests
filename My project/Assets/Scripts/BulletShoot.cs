using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    public GameObject bulletObj;
    public KeyCode bulletkey;
    public Transform bulletSpawn;
    private float direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(bulletkey))
        {
            GameObject bullet = Instantiate(bulletObj, bulletSpawn.position, Quaternion.identity);
            if (direction != 0)
                bullet.GetComponent<Bullet>().bulletDirection = direction;
            else
                bullet.GetComponent<Bullet>().bulletDirection = 1;
        }
        ;
    }
}
