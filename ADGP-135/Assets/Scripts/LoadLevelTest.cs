using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadLevelTest : MonoBehaviour
{

    public void Load(string lvl)
    {
        SceneManager.LoadScene(lvl);
    }
}
