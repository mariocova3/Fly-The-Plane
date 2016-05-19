using UnityEngine;
using System.Collections;

public class gameAndScore : MonoBehaviour 
{
	public GameObject rocks;
	int score = 0;

	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("CreateObstacle", 1f, 1.5f);
	}

	void CreateObstacle()
	{
		Instantiate (rocks);
		score++;
	}

	void OnGUI()
	{
		GUI.color = Color.black;
		GUILayout.Label ("Score: " + score.ToString ());
	}
}
