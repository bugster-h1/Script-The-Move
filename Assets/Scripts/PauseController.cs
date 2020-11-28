using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public GameObjectPause[] gameObjects;

    public void TogglePause()
	{
		Time.timeScale = Time.timeScale == 1 ? 0 : 1;

		foreach (var item in gameObjects)
		{
			item.GameObject.SetActive(!item.GameObject.activeSelf);
		}
	}
}

[Serializable]
public class GameObjectPause
{
    public GameObject GameObject;
    public bool SetActive;
}
