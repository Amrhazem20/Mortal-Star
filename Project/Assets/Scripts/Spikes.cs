using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour {

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
            //if the collider of the object whose name is Sonic GameObjects touches the checkpoint's circle collider 
            FindObjectOfType<PlayerStats>().SpikesDeath();
            FindObjectOfType<LevelManager>().RespawnPlayer();
        }


    }
}
