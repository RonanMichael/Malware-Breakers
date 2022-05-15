using UnityEngine.SceneManagement;
using UnityEngine;

public class Console3 : MonoBehaviour
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

        if (guess == "public class Puppy{}" || guess == "3")
        {
            SceneManager.LoadScene("Level 4");
        }
        else
        {
            SceneManager.LoadScene("Level 3");
        }

    }
}
