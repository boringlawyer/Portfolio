using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour 
{
	// the target position
	Vector3 current;
	[SerializeField] Vector3 position1;
	[SerializeField] Vector3 position2;
	[SerializeField] float speed;
	// Use this for initialization
	void Start () 
	{
		current = position1;
		StartCoroutine(Move());
	}
	// this will be in an infinite loop
	IEnumerator Move()
	{
		Vector3 finalDestination = current;
		Vector3 velocityHeading = (finalDestination - transform.position).normalized;
		while (Vector3.Distance(transform.position, finalDestination) > .1f)
		{
			GetComponent<Rigidbody2D>().velocity = velocityHeading * speed;
			if (Vector3.SqrMagnitude(transform.position - finalDestination) < .05)
			{
				break;
			}
			yield return null;
		}
		current = (current == position1) ? position2 : position1;
		StartCoroutine(Move());
	}
}
