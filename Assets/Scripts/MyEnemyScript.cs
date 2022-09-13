using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEnemyScript : MonoBehaviour
{
    [SerializeField] private int health;
    public void Hurt(int _damage)
    {
        Debug.Log("Hit:" + _damage);
        health -= _damage;
        if(health <= 0)
        {
            Die();
        }

    }
    
    public void Die()
    {
        Destroy(gameObject);

    }
}

