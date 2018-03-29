using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
// Caleb Katzenstein
// Displacement
// Indirectly controlled by the player. The goal is to keep this from harm
public class Ball : Floater 
{
	// Destroys itself if it collides with an enemy
	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.CompareTag("Enemy"))
		{
			EventSystem.GameOver();
		}
	}

}
