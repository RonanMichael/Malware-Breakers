using UnityEngine.SceneManagement;
using UnityEngine;

public class Console6 : MonoBehaviour
{
    public GameObject player;

    void Update()
    {



        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            player.transform.position = new Vector3(-9, 0, 5);
        }

    }

    public void GetInput(string guess)
    {
        Debug.Log("You entered:" + guess);

        if (guess == "String name;" || guess == "1")
        {
            SceneManager.LoadScene("Level 7");
        }
        else
        {
            SceneManager.LoadScene("Level 6");
        }

    }
}
