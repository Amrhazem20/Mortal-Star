using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Animator ani;
    public int MaxHealth = 20;
    public int CurrHealth;

    // Start is called before the first frame update
    public void Start()
    {
        CurrHealth = MaxHealth;
    }


    public void TakeDamage(int damage)
    {
        CurrHealth -= damage;

        ani.SetTrigger("Hurt");

        if (CurrHealth <= 0)
        {
            Die();
        }


    }

    public void Die()
    {

        ani.SetBool("IsDead", true);
        Debug.Log("Enemy Died");
        Destroy(this.gameObject);

    }

}
