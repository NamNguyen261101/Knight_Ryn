using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float attackCoolDown;

    [SerializeField] private Transform windPoint;

    [SerializeField] private GameObject projectible;
    
    private Animator anim;
    [SerializeField]  private bool canShoot = true;
    // private float cooldownTimer = Mathf.Infinity;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) )
        {
            Attack();
        }
        // cooldownTimer += Time.deltaTime;
    }

    private void Attack()
    {
        
        // cooldownTimer = 0;
        // Spam a projectile

        // Where to spam a projectile
        GameObject windCLone = (GameObject) Instantiate(projectible, windPoint.position, windPoint.rotation);
        anim.SetTrigger("attack");

    }

}
