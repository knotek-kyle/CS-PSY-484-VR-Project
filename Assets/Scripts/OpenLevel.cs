using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Kyle Knotek

public class OpenLevel : MonoBehaviour
{
    //opens a specific scene according to input string
    public string levelName;
    public void OpenScene()
    {
        SceneManager.LoadScene(levelName);
    }
}
