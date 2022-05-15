using UnityEngine.SceneManagement;
using UnityEngine;

public class Console10 : MonoBehaviour
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

        if (guess == "public static void main(String args){}" || guess == "3")
        {
            SceneManager.LoadScene("MainMenu");
        }
        else
        {
            SceneManager.LoadScene("Level 10");
        }

    }
}
