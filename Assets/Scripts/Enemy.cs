using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected Rigidbody enemyRb;
    protected GameObject player;

    public float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Attack(); // ABSTRACTION
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }

    public abstract void Attack();
}
