using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Exit : MonoBehaviour 
{
	[SerializeField] string levelName;
	// proceeds to the next level if the marble touches this
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.GetComponent<Marble>() != null)
		{
			SceneManager.LoadSceneAsync(levelName);
		}
	}
}
