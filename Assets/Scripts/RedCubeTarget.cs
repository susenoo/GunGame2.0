using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCubeTarget : MonoBehaviour {

    public float health = 50.0f;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0.0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
