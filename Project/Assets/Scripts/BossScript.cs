using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BossScript : MonoBehaviour
{
    public int MaxHealth = 100;
    public int CurrHealth;
    public Slider BossUI;

    // Start is called before the first frame update
    public void Start()
    {
        CurrHealth = MaxHealth;
    }


    public void TakeDamage(int damage)
    {
        CurrHealth -= damage;

        if (CurrHealth <= 0)
        {
            Die();
        }


    }

    public void Die()
    {

        Debug.Log("Boss Died");
        Destroy(this.gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        BossUI.value = MaxHealth;

    }
}
