using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneHandler : MonoBehaviour

{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void SaveScene()
    {
        int activeScene = SceneManager.GetActiveScene().buildIndex;

        PlayerPrefs.SetInt("ActiveScene", activeScene);
    }

    public void LoadScene()
    {
        int activeScene = PlayerPrefs.GetInt("ActiveScene");


        StartCoroutine(LoadNewScene(activeScene));
    }

    IEnumerator LoadNewScene(int sceneBuildIndex)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneBuildIndex);
        asyncOperation.allowSceneActivation = false;

        while (asyncOperation.progress < 0.9f)
        {
            yield return null;
        }

        asyncOperation.allowSceneActivation = true;

    }
}
