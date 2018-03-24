using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seeker : Trooper 
{
	bool isSeekingPlayer = true;	
	// Update is called once per frame
	void Update () 
	{
		if (isSeekingPlayer)
		{
			MoveTowardsPlayer();
		}
		transform.up = GameObject.Find("Ball").transform.position - this.transform.position;
	}

	IEnumerator Stun()
	{
		isSeekingPlayer = false;
		yield return new WaitForSeconds(5);
		isSeekingPlayer = true;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.GetComponent<Bubble>() != null)
		{
			StartCoroutine(Stun());
		}
	}
}
