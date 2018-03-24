using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// the base class of all objects who float, and are affected by bubbles
public class Floater : MonoBehaviour 
{
	protected Rigidbody2D rb;
	// amount displaced by bubble
	[SerializeField] protected float displacementForce;

	virtual protected void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	protected virtual void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Bubble"))
		{
			rb.velocity = (this.transform.position - other.transform.position).normalized * displacementForce;
		}
	}
}
