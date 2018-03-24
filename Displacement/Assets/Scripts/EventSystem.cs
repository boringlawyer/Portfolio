using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public static class EventSystem
{
	public static void GameOver()
	{
		EditorSceneManager.LoadSceneAsync(0);
	}
}
