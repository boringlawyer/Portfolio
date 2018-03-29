using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Caleb Katzenstein
// Arrow
// Launches targets throughout the game
public class TargetLauncher : MonoBehaviour 
{
	[SerializeField] GameObject target;
	// Use this for initialization
	void Start () 
	{
		StartCoroutine(LaunchTarget());
	}
	// creates a target every three seconds
	IEnumerator LaunchTarget()
	{
		while (true)
		{
			Instantiate(target, Vector3.one * -2, Quaternion.identity);
			yield return new WaitForSeconds(3);
		}
		yield return null;
	}
}
