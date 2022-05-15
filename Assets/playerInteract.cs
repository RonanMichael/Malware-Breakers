using UnityEngine.SceneManagement;
using UnityEngine;

public class playerInteract : MonoBehaviour
{

    private bool check = false;

    void Update()
    {
        string levelName = SceneManager.GetActiveScene().name;
        RaycastHit hit;
        Ray touchRay = new Ray(transform.position, Vector3.forward);

            if (Input.GetKey(KeyCode.F))
            {
                if(Physics.Raycast(touchRay, out hit))
                {
                    if (hit.collider.name == "console1")
                    {
                    
                    SceneManager.LoadScene("Level 1 Console");

                    }
                    else if (hit.collider.name == "console2")
                    {

                    SceneManager.LoadScene("Level 2 Console");

                    }
                    else if (hit.collider.name == "console3")
                    {

                    SceneManager.LoadScene("Level 3 Console");

                    }
                    else if (hit.collider.name == "console4")
                    {

                    SceneManager.LoadScene("Level 4 Console");

                    }
                    else if (hit.collider.name == "console5")
                    {

                    SceneManager.LoadScene("Level 5 Console");

                    }
                    else if (hit.collider.name == "console6")
                    {

                    SceneManager.LoadScene("Level 6 Console");

                    }
                    else if (hit.collider.name == "console7")
                    {

                    SceneManager.LoadScene("Level 7 Console");

                    }
                    else if (hit.collider.name == "console8")
                    {

                    SceneManager.LoadScene("Level 8 Console");

                    }
                    else if (hit.collider.name == "console9")
                    {

                    SceneManager.LoadScene("Level 9 Console");

                    }
                    else if (hit.collider.name == "console10")
                    {

                    SceneManager.LoadScene("Level 10 Console");

                    }
            }
    }

    }
}
