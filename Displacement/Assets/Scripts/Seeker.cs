using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Caleb Katzenstein
// Displacement
// Enemy that moves towards player continuously
public class Seeker : Trooper 
{
	bool isSeekingPlayer = true;	
	// points towards and move towards player
	void Update () 
	{
		if (isSeekingPlayer)
		{
			MoveTowardsPlayer();
		}
		transform.up = GameObject.Find("Ball").transform.position - this.transform.position;
	}
	// this stops seeking the player
	IEnumerator Stun()
	{
		isSeekingPlayer = false;
		yield return new WaitForSeconds(5);
		isSeekingPlayer = true;
	}
	// gets stunned if a bubble hits this
	protected override void OnTriggerEnter2D(Collider2D other)
	{
		base.OnTriggerEnter2D(other);
		if (other.GetComponent<Bubble>() != null)
		{
			StartCoroutine(Stun());
		}
	}
}
