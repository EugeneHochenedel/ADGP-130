using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
	
	public void Exit(string ext)
	{
		SceneManager.LoadScene(ext);
	}

}
