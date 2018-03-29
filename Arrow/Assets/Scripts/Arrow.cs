using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Arrow : MonoBehaviour 
{
	public UnityEvent scoreIncrease;
	Rigidbody2D rb;
	// Use this for initialization
	void Start () 
	{
		scoreIncrease = new UnityEvent();
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButton(0))
		{
			Vector3 newForward = MousePos.MousePosition - transform.position;
			// if the mouse is on the arrow, do nothing
			if (newForward == Vector3.zero)
			{
				return;
			}
			// else, aim this away from the mouse if this is not already moving
			if (rb.velocity == Vector2.zero)
			{			
				transform.up = -(MousePos.MousePosition - transform.position);
			}		
		}
	}

	void FixedUpdate()
	{
		// launch this if LMB is released
		if (Input.GetMouseButtonUp(0) && rb.velocity == Vector2.zero)
		{
			rb.AddForce((transform.position - MousePos.MousePosition).normalized * 350);
		}
		// destroy if out of bounds
		if (Vector3.SqrMagnitude(transform.position - Vector3.zero) > 225)
		{
			Destroy(this.gameObject);
		}
	}
}
