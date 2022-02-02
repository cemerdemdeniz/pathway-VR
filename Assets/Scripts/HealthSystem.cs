using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public abstract class HealthSystem : MonoBehaviour
{
    public float health;
    public float maxHealth;

    public abstract float CalculateHealth();
    public abstract bool LessThanMaxHealth();
    public abstract bool GreaterThanMaxHealth();
    public abstract bool LessThanZero();

}
