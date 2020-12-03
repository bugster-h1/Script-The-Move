using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PauseController : MonoBehaviour
{
	public static Dictionary<int, bool> initialStates = new Dictionary<int, bool>();

    public GameObject[] objectsToDisableOnPause;
	public GameObject pauseMenu;

    public void Pause()
	{
		Time.timeScale = 0;
		initialStates = objectsToDisableOnPause.ToDictionary(x => x.GetHashCode(), x => x.activeSelf);

		foreach (var item in objectsToDisableOnPause)
		{
			item.SetActive(false);
		}

		pauseMenu.SetActive(true);
	}

	public void UnPause()
	{
		Time.timeScale = 1;

		foreach (var item in objectsToDisableOnPause)
		{
			item.SetActive(initialStates[item.GetHashCode()]);
		}

		pauseMenu.SetActive(false);
	}
}


