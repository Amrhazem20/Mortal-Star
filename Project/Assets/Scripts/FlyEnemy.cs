using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyEnemy : EnemyController {
	public float HorizontalSpeed;
	public float VerticalSpeed;
	public float amplitude;
	private Vector3 tempPosition;
	private Controller player;
	// Use this for initialization
	void Start () {
		tempPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void FixedUpdate()
    {
		tempPosition.x += HorizontalSpeed;
		tempPosition.y+=Mathf.Sin(Time.realtimeSinceStartup*VerticalSpeed)*amplitude;
		transform.position = tempPosition;
    }
}
