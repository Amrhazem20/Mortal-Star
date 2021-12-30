using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossLevel : MonoBehaviour
{
    public Animator ani;
    public int MaxHealth = 20;
    public int CurrHealth;
    public Slider HealthUI;
    // Start is called before the first frame update
    void Start()
    {
        CurrHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        HealthUI.value = MaxHealth;
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
