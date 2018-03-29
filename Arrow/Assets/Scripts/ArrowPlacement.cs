using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Caleb Katzenstein
// Arrow
// Places an arrow where the mouse is upon a left click
public class ArrowPlacement : MonoBehaviour 
{
	[SerializeField] GameObject arrow;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown(0))
		{
			Instantiate(arrow, MousePos.MousePosition + Vector3.up, Quaternion.identity);
		}
	}
}
