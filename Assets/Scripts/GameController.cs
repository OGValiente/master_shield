using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	public Button startButton;
	public Button quitButton;
	public string sceneToLoad;
	void Start()
	{
		startButton.onClick.AddListener(LoadGameState);
		quitButton.onClick.AddListener(QuitGame);
	}

	void Update()
    {
    }

	void PauseButtonClicked()
	{
		Time.timeScale = 0;
	}

	void ResumeButtonClicked()
	{
		Time.timeScale = 1;
	}

	void LoadGameState()
	{
		SceneManager.LoadScene(sceneToLoad);
	}

	void QuitGame()
	{
		//Maybe ask with a pop-up if the user is sure or not
		Application.Quit();
	}
}
