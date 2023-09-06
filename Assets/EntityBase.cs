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
    private int health;
    public EntityTypes EntityType;
    [SerializeField] private float InvincibilityDuration = .1f;
    private float iFrames = 0;

    public abstract bool TryDamage();

    public abstract void Death();
}
