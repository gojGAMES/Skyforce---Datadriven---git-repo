using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardBullet : BulletBase
{
    public float Speed = 20f;
    public float LiveDuration = 4;
    [SerializeField] private Vector3 Direction = Vector3.up;
    // Start is called before the first frame update
    void Start()
    {
        Direction = Angle2Vector(transform.rotation.eulerAngles.z);
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

        // Update is called once per frame
    void Update()
    {
        LiveDuration -= Time.deltaTime;
        transform.position += Direction * Speed * Time.deltaTime;
        if (LiveDuration <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("bullet detects collision");
        if (coll.gameObject.TryGetComponent(out EntityBase entity))
        {
            if (TargetTypesList.Contains(entity.EntityType))
            {
                if (entity.TryDamage(Damage))
                {
                    OnHit();
                }
            }
        }
    }

    protected override void OnHit()
    {
        Destroy(gameObject);
    }
}
