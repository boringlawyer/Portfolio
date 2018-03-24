using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Exit : MonoBehaviour {

	// Use this for initialization
	[SerializeField] string levelName;
	void Start () {
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.GetComponent<Marble>() != null)
		{
			SceneManager.LoadSceneAsync(levelName);
		}
	}
}
