using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Ball : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		
	}

	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.CompareTag("Enemy"))
		{
			EventSystem.GameOver();
		}
	}
}
