using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    public Animator ani;
    public int MaxHealth = 20;
    public int CurrHealth;
    public Slider EnemyUI;

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

     void Update()
    {
        EnemyUI.value = MaxHealth;
    }
}
