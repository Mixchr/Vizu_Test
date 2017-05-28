using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange2 : MonoBehaviour 


	
	{
	public void ChangeScene()
		{
		Debug.LogError ("test");
		SceneManager.LoadScene("VizuStart", LoadSceneMode.Single);


		}
	}
