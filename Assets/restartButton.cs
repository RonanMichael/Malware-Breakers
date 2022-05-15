using UnityEngine.SceneManagement;
using UnityEngine;

public class restartButton : MonoBehaviour
{
    void Update()  
    {

        if (Input.GetKey(KeyCode.Backspace))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
