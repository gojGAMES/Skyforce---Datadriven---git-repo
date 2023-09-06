using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class GunBase : MonoBehaviour
{
    public float FireRate;
    public float FireOffset;
    public GameObject Bullet;
    public Vector3 BulletSpawnPos;
    
    private float fireCooldown = 0;
    // Start is called before the first frame update
    void Start()
    {
        fireCooldown = 0 + FireOffset;
        if (BulletSpawnPos == null)
        {
            BulletSpawnPos = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (fireCooldown >= 0)
        {
            fireCooldown -= Time.deltaTime;
            return;
        }
        //Debug.Log("Fire at "+Time.time);
        SpawnBullet();
        fireCooldown = FireRate;
    }

    void SpawnBullet()
    {
        Instantiate(Bullet, transform.position + BulletSpawnPos, transform.rotation);
    }

    private void OnEnable()
    {
        fireCooldown = 0.0f + FireOffset;
    }
}
