using UnityEngine;
using UnityEngine.SceneManagement;


public class respawnPlayer : MonoBehaviour
{

    //public GameObject spawnPoint;
    private void Start()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "hazard")
        {
            string sceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(sceneName);
        }
    }
}