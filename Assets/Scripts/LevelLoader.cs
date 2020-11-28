using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
	public Animator transition;
	public float transitionTime = 1f;

	public void RestartScene()
	{
		Time.timeScale = 1f;

		LoadScene(SceneManager.GetActiveScene().name);
	}

	public void LoadScene(string sceneName)
	{
		Time.timeScale = 1f;

		StartCoroutine(LoadSceneCoroutine(sceneName));
	}

	IEnumerator LoadSceneCoroutine(string sceneName)
	{
		transition.SetTrigger("Start");

		yield return new WaitForSeconds(transitionTime);

		SceneManager.LoadScene(sceneName);
	}
}
