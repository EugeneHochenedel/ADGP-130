using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndGameScript : MonoBehaviour
{

    public void Load(string e)
    {
        SceneManager.LoadScene(e);
    }

	//void Start()
	//{
		
	//}

    // Update is called once per frame
    void Update()
    {

        if ((transform.position.x >= 646 && transform.position.x <= 894) &&
            (transform.position.y <= 129 && transform.position.y >= 83) &&
            (transform.position.z <= -317 && transform.position.z >= -435))
        {
            Load("TheEnd");
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
        }
    }
}