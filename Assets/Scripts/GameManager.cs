using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public static GameManager instance;

	private void Awake()
	{
		instance = this;
	}
	public void Finish()
	{
		SceneManager.LoadScene(2);
	}
	public void TryAgain()
	{
		SceneManager.LoadScene(1);
	}
	public void StartGame()
	{
		SceneManager.LoadScene(1);
	}
	public void GoMenu()
	{
		SceneManager.LoadScene(0);
	}
}
