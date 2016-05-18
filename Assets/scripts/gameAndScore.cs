using UnityEngine;
using System.Collections;

public class gameAndScore : MonoBehaviour 
{
	public GameObject rocks;

	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("CreateObstacle", 1f, 1.5f);
	}

	void CreateObstacle()
	{
		Instantiate (rocks);
	}
}
