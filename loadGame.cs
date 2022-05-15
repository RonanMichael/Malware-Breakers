using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadGame : MonoBehaviour
{
    private sceneHandler sceneHandler;

    void Awake()
    {
        sceneHandler = GameObject.FindObjectOfType<sceneHandler>();

    }

    public void loadScene()
    {

            Debug.Log("Load Successful");
            sceneHandler.LoadScene();

    }
}