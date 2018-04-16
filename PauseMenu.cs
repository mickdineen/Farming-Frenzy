using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
public class PauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;
	public GameObject PauseMenuUI;


	void Start() {
		PauseMenuUI.SetActive (false);
	}

	void Update(){
		if (Input.GetButtonDown ("Pause")) {
			GameIsPaused = !GameIsPaused;
		}
		if(GameIsPaused){
			PauseMenuUI.SetActive (true);
			Time.timeScale = 0;
			
	}
		if (!GameIsPaused) {
		
			PauseMenuUI.SetActive (false);
			Time.timeScale = 1;
		}
			
	
	//void Update () {

	//	if(Input.GetKeyDown(KeyCode.Escape))
	

	//	if(GameIsPaused){
	//	Resume();
		} 
	//else
	//	{

	//	Pause();
	//	}
	//}


		public void Resume()
	{
		PauseMenuUI.SetActive(false);
		Time.timeScale= 1f;
		GameIsPaused = false;
	}

		void Pause()
	{
		PauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}

	public void LoadMenu()
	{
		EditorSceneManager.LoadScene("April8");
	}
	public void DeMenu ()
	{
		Debug.Log ("Quitting game ...");
		Application.Quit();
	}
		}
