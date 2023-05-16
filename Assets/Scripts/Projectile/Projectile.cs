using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rigidBody;


    [SerializeField] private GameObject windEffect;

    private float direction;
    private bool hit;

    
    
    private void Awake()
    {
       rigidBody = GetComponent<Rigidbody2D>();
       
    }

    private void Update()
    {
        // transform.Translate(transform.right * transform.localScale.x * speed * Time.deltaTime);
        rigidBody.velocity = new Vector2(speed * transform.localScale.x, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");
        Instantiate(windEffect, transform.position, transform.rotation);
        if (collision.tag == "Player")
        {
            return;
        }

        // - health
        // var enemyComponent = GetComponent<EnemyHealth>();
        // if (enemyComponent != null) {Destroy(gameObject)}
        // Destroy
        Debug.Log(collision.gameObject);
        Destroy(gameObject);
    }

   
}
