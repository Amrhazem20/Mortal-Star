using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour {
	public AudioClip coin1;
	public AudioClip coin2;
	public int value =1;
	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
			AudioManager.instance.RandomSfx(coin1, coin2);
			FindObjectOfType<PlayerStats>().CollectSouls(value);
			Destroy(this.gameObject);
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
