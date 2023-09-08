using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : EntityBase
{
    private SpriteRenderer _spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (iFrames > 0)
        {
            iFrames -= Time.deltaTime;
            float colorVal = 1f - Mathf.Clamp((float)iFrames / (float)InvincibilityDuration, 0, 1);
            _spriteRenderer.color = new Color(1, colorVal, colorVal);
        }
    }

    protected override void OnHit(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Death();
            return;
        }

        iFrames = InvincibilityDuration;
    }

    public override void Death()
    {
        throw new System.NotImplementedException();
    }
}
