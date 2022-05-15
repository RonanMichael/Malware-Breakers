using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class saveGame : MonoBehaviour
{
    private sceneHandler sceneHandler;

    void Awake()
    {
        sceneHandler = GameObject.FindObjectOfType<sceneHandler>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("Save Successful");
            sceneHandler.SaveScene();
            SceneManager.LoadScene("MainMenu");
        }
    }
}