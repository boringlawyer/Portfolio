using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Ball : Floater 
{

	// Use this for initialization
	protected override void Start () 
	{
		base.Start();
	}

	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.CompareTag("Enemy"))
		{
		//	EventSystem.GameOver();
		}
	}

	/*protected override void OnTriggerEnter2D(Collider2D other)
	{
		base.OnTriggerEnter2D(other);
	}*/
}
