using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {
	private Collider2D coll;
	public static List<Collider2D> allColliders;
	// Use this for initialization
	void Start () 
	{
		allColliders = new List<Collider2D>();
		allColliders.Add(coll);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
