using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Caleb Katzenstein
// Displacement
// the base class of all objects who are affected by bubbles
public class Floater : MonoBehaviour 
{
	protected Rigidbody2D rb;
	// amount displaced by bubble
	[SerializeField] protected float displacementForce;

	virtual protected void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	// if bubble reaches this, move away from the bubbles origin
	protected virtual void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Bubble"))
		{
			rb.velocity = (this.transform.position - other.transform.position).normalized * displacementForce;
		}
	}

	protected void MoveTowardsPlayer()
	{
		rb.velocity = (GameObject.Find("Ball").transform.position - this.transform.position).normalized * 2;
	}

}
