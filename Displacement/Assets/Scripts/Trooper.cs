using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Caleb Katzenstein
// Displacement
// Basic enemy script
public class Trooper : Floater
{
	protected override void Start() 
	{
		base.Start();
		MoveTowardsPlayer();
	}
}
