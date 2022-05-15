using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deactivateLazer : MonoBehaviour
{

    public GameObject lazer;

    //GameObject lazerCol;

    private void Start()
    {
        //lazer = lazer.GetComponent<BoxCollider>();
    }

    void OnTriggerEnter(Collider col)
    {
            if (col.transform.tag == "Player")
            {
                Debug.Log("It worked");
                (lazer.GetComponent(typeof(BoxCollider)) as Collider).enabled = false;
                (lazer.GetComponent(typeof(MeshRenderer)) as Renderer).enabled = false;
        }

        }
    }
