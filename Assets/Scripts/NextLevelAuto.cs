using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Kyle Knotek

public class NextLevelAuto : MonoBehaviour
{
    public string levelName;
    void Start()
    {
        SceneManager.LoadScene(levelName);
    }
}
