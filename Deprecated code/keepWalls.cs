using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepWalls : MonoBehaviour
{

    //public GameObject walls;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
