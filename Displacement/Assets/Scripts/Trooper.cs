using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Basic enemy script
public class Trooper : Floater {

	// Use this for initialization
	protected override void Start() 
	{
		base.Start();
		MoveTowardsPlayer();
	}
	protected void MoveTowardsPlayer()
	{
		rb.velocity = (GameObject.Find("Ball").transform.position - this.transform.position).normalized * 2;
	}
}
