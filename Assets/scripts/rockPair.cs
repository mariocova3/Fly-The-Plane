﻿using UnityEngine;

public class rockPair : MonoBehaviour 
{

	public Vector2 velocity = new Vector2 (-4, 0);

	// Use this for initialization
	void Start () 
	{
		GetComponent<Rigidbody2D> ().velocity = velocity;
	}
}
