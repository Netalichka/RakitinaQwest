using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private Vector3 direction;

    
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

    }
    private void FixedUpdate()
    {
        Vector3 speed = direction * speed * Time.deltaTime;
        transform.Translate(speed);
    }
}
