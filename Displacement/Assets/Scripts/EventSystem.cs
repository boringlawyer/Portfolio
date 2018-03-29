using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
// Caleb Katzenstein
// Displacement
// Contains methods that should be accessible to all classes
public static class EventSystem
{
	public static void GameOver()
	{
		EditorSceneManager.LoadSceneAsync(0);
	}
}
