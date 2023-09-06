using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EntityTypes
{
    Player,
    Enemy
}
public abstract class EntityBase : MonoBehaviour
{
    [SerializeField] protected int health;
    public EntityTypes EntityType;
    [SerializeField] protected float InvincibilityDuration = .1f;
    protected float iFrames = 0;

    public bool TryDamage(int damage)
    {
        if (iFrames > 0)
        {
            return false;
        }
        OnHit(damage);
        return true;
    }

    protected abstract void OnHit(int damage);

    public abstract void Death();
}
