using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
// Caleb Katzenstein
// Dasher
// List of essential methods that all scripts have access to
public static class EventSystem
{
	public static void GameOver()
	{
		EditorSceneManager.LoadSceneAsync(0);
	}
}
