using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolaCalculator : MonoBehaviour {
	LineRenderer lineRenderer;
	Vector3[] calculatedPositions;
	// Use this for initialization
	void Start () 
	{
		lineRenderer = GetComponent<LineRenderer>();
		calculatedPositions = new Vector3[21];
		calculatedPositions[0] = new Vector2(-1, -1);
		calculatedPositions[1] = new Vector2(-.9f, -.81f);
		calculatedPositions[2] = new Vector2(-.8f, -.64f);
		calculatedPositions[3] = new Vector2(-.7f, -.49f);
		calculatedPositions[4] = new Vector2(-.6f, -.36f);
		calculatedPositions[5] = new Vector2(-.5f, -.25f);
		calculatedPositions[6] = new Vector2(-.4f, -.16f);
		calculatedPositions[7] = new Vector2(-.3f, -.09f);
		calculatedPositions[8] = new Vector2(-.2f, -.04f);
		calculatedPositions[9] = new Vector2(-.1f, -.01f);
		calculatedPositions[10] = new Vector2(0f, 0f);
		calculatedPositions[11] = new Vector2(.1f, -.01f);
		calculatedPositions[12] = new Vector2(.2f, -.04f);
		calculatedPositions[13] = new Vector2(.3f, -.09f);
		calculatedPositions[14] = new Vector2(.4f, -.16f);
		calculatedPositions[15] = new Vector2(.5f, -.25f);
		calculatedPositions[16] = new Vector2(.6f, -.36f);
		calculatedPositions[17] = new Vector2(.7f, -.49f);
		calculatedPositions[18] = new Vector2(.8f, -.64f);
		calculatedPositions[19] = new Vector2(.9f, -.81f);
		calculatedPositions[20] = new Vector2(1f, -1f);
		lineRenderer.positionCount = 21;
		lineRenderer.SetPositions(calculatedPositions);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
