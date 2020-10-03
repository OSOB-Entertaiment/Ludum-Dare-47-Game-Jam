using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 100;
    private int currenHealth;
    void Start()
    {
        currenHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currenHealth -= damage;
        animator.SetTrigger("Hurt");
        if (currenHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        animator.SetBool("IsDead", true);
        //GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
}
