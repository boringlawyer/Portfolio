using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour 
{
	/*[SerializeField] Transform[] cameraDestinations;
	[SerializeField] Collider2D[] colliders;
	[SerializeField] Rigidbody2D player;
	Vector3 nextPosition;
	// Use this for initialization
	void Start () 
	{
		nextPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		for (int i = 0; i < colliders.Length; i++)
		{
			if (player.IsTouching(colliders[i]))
			{
				nextPosition = cameraDestinations[i].position;
				StartCoroutine(Move(nextPosition));
			}
		}
	}
	IEnumerator Move(Vector3 position)
	{
		float totalSqrDistance = Vector3.SqrMagnitude(position - transform.position);
		float currentSqrDistance = totalSqrDistance;
		while (currentSqrDistance > 100)
		{ 
			transform.position = Vector3.Lerp(transform.position, position, 1 - (currentSqrDistance / totalSqrDistance) + .01f);
			transform.position = new Vector3(transform.position.x, transform.position.y, -10);
			currentSqrDistance = Vector3.SqrMagnitude(position - transform.position);
			yield return null;
		}
		StartCoroutine(Follow());
	}
	IEnumerator Follow()
	{
		while (true)
		{
			transform.position = nextPosition + Vector3.forward * -10;
			yield return null;
		}
	}*/
	[SerializeField] Transform player;
	// distance this from the player by a set amount in the -z direction
	void Update()
	{
		transform.position = player.position + Vector3.forward * -10;
	}
}
