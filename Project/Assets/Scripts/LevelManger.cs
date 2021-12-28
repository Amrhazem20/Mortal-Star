using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManger : MonoBehaviour {

    public GameObject CurrentCheckpoint; //so we can update the current checkpoint from within Unity
    public Transform Player;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RespawnPlayer()
    {
        FindObjectOfType<Controller>().transform.position = CurrentCheckpoint.transform.position;//Search for the asset/object called //Controller (your player's script code name whatever it is). Once you've found it, change its player game object's position //to be at thew last checkpoint the player passed through before s/he died } 
    }

}
