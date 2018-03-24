using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLauncher : MonoBehaviour 
{
	[SerializeField] GameObject target;
	// Use this for initialization
	void Start () 
	{
		StartCoroutine(LaunchTarget());
	}
	
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
