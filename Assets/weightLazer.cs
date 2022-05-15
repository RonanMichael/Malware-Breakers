using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weightLazer : MonoBehaviour
{

    public GameObject lazer;

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "Player")
        {
            (lazer.GetComponent(typeof(BoxCollider)) as Collider).enabled = false;
            (lazer.GetComponent(typeof(MeshRenderer)) as Renderer).enabled = false;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.transform.tag == "Player")
        {
            (lazer.GetComponent(typeof(BoxCollider)) as Collider).enabled = true;
            (lazer.GetComponent(typeof(MeshRenderer)) as Renderer).enabled = true;
        }
    }
}
