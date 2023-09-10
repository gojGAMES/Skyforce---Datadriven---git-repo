using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBullet : BulletBase
{
    public float Duration;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Duration -= Time.deltaTime;
        if (Duration < 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out EntityBase entity))
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
        
    }
}
