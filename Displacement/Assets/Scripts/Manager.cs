using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour 
{
	[SerializeField] GameObject bubblePrefab;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown(0))
		{
			Instantiate(bubblePrefab, MousePos.MousePosition, Quaternion.identity);
		}
		if (Input.touchCount > 0)
		{
			Instantiate(bubblePrefab, Input.touches[0].position, Quaternion.identity);
		}
	}
}
