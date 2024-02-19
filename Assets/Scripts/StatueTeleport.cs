using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StatueTeleport : MonoBehaviour
{
    public string levelName;
    private void OnTriggerEnter(Collider collision) 
    {
        if(collision.CompareTag("TeleportP"))
        {
            SceneManager.LoadScene(levelName);
        }
    }

}
