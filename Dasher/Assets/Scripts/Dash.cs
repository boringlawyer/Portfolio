using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour 
{
	[SerializeField]float dashDistance = 5;
	bool isOnPlatform = true;
	[SerializeField] float speed;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		// lmb triggers dash
		if (Input.GetMouseButtonDown(0))
		{
			// checks to see if this is already moving before dashing again
			if (GetComponent<Rigidbody2D>().velocity == Vector2.zero)
			{
				StartCoroutine(Move(MousePos.MousePosition));
			}
			// interrupt current dash, start new dash
			else
			{
				StopAllCoroutines();
				StartCoroutine(Move(MousePos.MousePosition));
			}
		}
		// end game if player is not visible
		if (!GetComponent<Renderer>().isVisible)
		{
			// There was a glitch where this was invisible in the beginning, this fixes that
			if (Time.timeSinceLevelLoad > .5)
			{
				EventSystem.GameOver();
			}
		}
	}
	// Handles the "dash"
	IEnumerator Move(Vector3 location)
	{
		// stop being attached to platforms when moving
		if (transform.parent != null)
		{
			transform.parent.DetachChildren();
		}
		Vector3 oldPosition = transform.position;
		Vector3 velocityHeading = (location - oldPosition).normalized;
		float sqrDistanceToTravel = Vector3.SqrMagnitude(location - oldPosition);
		// move to position until distance diminishes to a certain point
		while (Vector3.Distance(transform.position, location) > .1f)
		{
			GetComponent<Rigidbody2D>().velocity = velocityHeading * speed;
			if (Vector3.SqrMagnitude(transform.position - oldPosition) > sqrDistanceToTravel)
			{
				break;
			}
			yield return null;
		}
		// stop movement
		GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		// end game if player did not land on platform
		if (!isOnPlatform)
		{
			EventSystem.GameOver();
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Obstacle"))
		{
			EventSystem.GameOver();
		}
	}
	void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Platform"))
		{
			isOnPlatform = true;
			if (GetComponent<Rigidbody2D>().velocity == Vector2.zero)
			{
				transform.parent = other.transform;
			}
			else
			{
				if (transform.parent != null)
				{
					transform.parent.DetachChildren();
				}
			}
		}
	}
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Platform"))
		{
			isOnPlatform = false;
		}
	}
}
