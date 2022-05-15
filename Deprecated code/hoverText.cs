using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoverText : MonoBehaviour
{

    public GameObject clueText;
    //public GameObject faceCamera;

    // Start is called before the first frame update
    void Start()
    {
        clueText.SetActive(false);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.name == "Player")
        {
            clueText.SetActive(true);
            clueText.transform.LookAt(Camera.main.transform);
            //clueText.transform.localEulerAngles = new Vector3(0, 0, 180);
        }
    }
}
