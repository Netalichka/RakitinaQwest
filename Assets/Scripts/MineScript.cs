using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineScript : MonoBehaviour
{
    [SerializeField] private int _damage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            MyEnemyScript enemy = other.GetComponent<MyEnemyScript>();
            enemy.Hurt(_damage);

            Destroy(gameObject);
        }

    }
}
