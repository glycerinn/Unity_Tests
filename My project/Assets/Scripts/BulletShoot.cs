using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    public GameObject bulletObj;
    public KeyCode bulletkey;
    public Transform bulletSpawn;
    private float cooldown = 1;
    private float currentCooldown;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currentCooldown -= Time.deltaTime;
        if (currentCooldown <= 0)
        {
            if (Input.GetKeyDown(bulletkey))
            {
                SpawnBullet();
                currentCooldown = cooldown;
            }
        }
    }

    public void SpawnBullet()
    {
        GameObject bullet = Instantiate(bulletObj, bulletSpawn.position, quaternion.identity);
        bullet.GetComponent<Bullet>().bulletDirection = GetComponent<PlayerBehaviour>().facingRight;
    }
}
