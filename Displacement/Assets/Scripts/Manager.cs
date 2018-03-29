using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;

public class Manager : MonoBehaviour 
{
	[SerializeField] GameObject bubblePrefab;
	[SerializeField] GameObject trooperPrefab;
	[SerializeField] GameObject seekerPrefab;
	[SerializeField] GameObject minePrefab;
	[SerializeField] Text scoreText;
	int score;
	// Use this for initialization
	void Start () 
	{
		StartCoroutine(Spawn());
		StartCoroutine(ScoreLoop());
		score = 0;
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

	IEnumerator Spawn()
	{
		// determines what is spawned
		float locationDeterminant = Random.Range(0f, 1f);
		Vector2 spawnLoc = Vector2.zero;
		if (locationDeterminant < .25)
		{
			spawnLoc = new Vector2(-15, 7);
		}
		else if (locationDeterminant < .5)
		{
			spawnLoc = new Vector2(15, 7);
		}
		else if (locationDeterminant < .75)
		{
			spawnLoc = new Vector2(15, -7);
		}
		else
		{
			spawnLoc = new Vector2(-15, -7);
		}
		float objectDeterminant = Random.Range(0f, 1f);
		GameObject toSpawn = new GameObject();
		if (objectDeterminant < .6)
		{
			toSpawn = trooperPrefab;
		}
		else if (objectDeterminant < .8)
		{
			toSpawn = seekerPrefab;
		}
		else
		{
			toSpawn = minePrefab;
		}
		Instantiate(toSpawn, spawnLoc, Quaternion.identity);
		yield return new WaitForSeconds(5);
		StartCoroutine(Spawn());
	}

	void IncrementScore(int scoreIncrease)
	{
		score += scoreIncrease;
		scoreText.text = "Score: " + score;
	}

	IEnumerator ScoreLoop()
	{
		IncrementScore(1);
		yield return new WaitForSeconds(1);
		StartCoroutine(ScoreLoop());
	}
}
