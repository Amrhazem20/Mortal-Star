using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StompEnemy : MonoBehaviour {
	public GameObject enemy;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            enemy.GetComponent<Enemy>().TakeDamage(1);
        }
    }
}
