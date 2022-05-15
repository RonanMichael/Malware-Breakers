using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deactivateLazer2 : MonoBehaviour
{
    public GameObject lazer2;
    public GameObject lazer3;

    void OnTriggerEnter(Collider col)
    {
        {
            if (col.transform.tag == "Player")
            {
                Debug.Log("It worked");
                (lazer2.GetComponent(typeof(BoxCollider)) as Collider).enabled = false;
                (lazer3.GetComponent(typeof(BoxCollider)) as Collider).enabled = false;
                (lazer2.GetComponent(typeof(MeshRenderer)) as Renderer).enabled = false;
                (lazer3.GetComponent(typeof(MeshRenderer)) as Renderer).enabled = false;
            }
        }
    }
}
