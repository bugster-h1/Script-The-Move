using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public GameObject[] gameObjects;

    public void TogglePause()
	{
		Time.timeScale = Time.timeScale == 1 ? 0 : 1;

		foreach (var item in gameObjects)
		{
			item.SetActive(!item.activeSelf);
		}
	}
}

