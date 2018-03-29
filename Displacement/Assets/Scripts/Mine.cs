using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Caleb Katzenstein
// Displacement
// Destroys other enemies on collision
public class Mine : Floater 
{

	protected override void Start()
	{
		base.Start();
		MoveTowardsPlayer();
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.CompareTag("Enemy"))
		{
			Destroy(other.gameObject);
		}
	}
}
