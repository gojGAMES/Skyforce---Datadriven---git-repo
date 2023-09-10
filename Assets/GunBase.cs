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
    //TODO: Separate laser and bullet weapons using inheritance
    public bool isLaserWeapon = false;
    
    private float fireCooldown = 0;
    // Start is called before the first frame update
    void Start()
    {
        fireCooldown = 0 + FireOffset;
        if (BulletSpawnPos == null)
        {
            BulletSpawnPos = transform.position;
        }

        if (Bullet == null)
        {
            
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

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 1, 0, 0.5f);
        Gizmos.DrawLine(transform.position, transform.position + 2 * Angle2Vector(transform.rotation.eulerAngles.z));
    }
    
    Vector3 Angle2Vector(float degAng)
    {
        float radAng = 0;
        Vector2 answer;

        radAng = Mathf.Deg2Rad * (degAng + 90);

        answer = new Vector2(Mathf.Cos(radAng), Mathf.Sin(radAng));
        answer.Normalize();
        return new Vector3(answer.x, answer.y, 0);
    }

    void SpawnBullet()
    {
        if (!isLaserWeapon)
            Instantiate(Bullet, transform.position + BulletSpawnPos, transform.rotation);
        else
        {
            Instantiate(Bullet, transform.position + BulletSpawnPos, transform.rotation, transform);
        }
    }

    private void OnEnable()
    {
        fireCooldown = 0.0f + FireOffset;
    }
}
