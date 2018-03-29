using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Caleb Katzenstein
// Displacement
// Displaces other objects
public class Bubble : MonoBehaviour 
{
	LineRenderer lineRenderer;
	CircleCollider2D coll;
	[SerializeField] float maxSize;
	float size = 1;
	float lerpScale = .01f;
	// Use this for initialization
	void Start () 
	{
		// set up the lineRenderer to draw a circle
		lineRenderer = GetComponent<LineRenderer>();
		coll = GetComponent<CircleCollider2D>();
		for (int i = 0; i < lineRenderer.positionCount; i++)
		{
			float x = Mathf.Cos(2 * Mathf.PI * ((float)i / lineRenderer.positionCount)) * size;
			float y = Mathf.Sin(2 * Mathf.PI * ((float)i / lineRenderer.positionCount)) * size;
			lineRenderer.SetPosition(i, transform.position + new Vector3(x, y));
		}
		lineRenderer.positionCount += 1;
		lineRenderer.SetPosition(lineRenderer.positionCount - 1, lineRenderer.GetPosition(0));
	}
	
	// Expand the bubble until it reaches max size
	void Update () 
	{
		size = Mathf.Lerp(size, maxSize, lerpScale);
		for (int i = 0; i < lineRenderer.positionCount; i++)
		{
			Vector3 result = lineRenderer.GetPosition(i) - transform.position;
			result = result.normalized;
			result *= size;
			result += transform.position;
			lineRenderer.SetPosition(i, result);
		}
		coll.radius = size;
		lerpScale += .01f;
		if (size >= maxSize)
		{
			Destroy(this.gameObject);
		}
	}

}
