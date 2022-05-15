using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayClues : MonoBehaviour
{
    //public GameObject clue;
    public CanvasGroup clueText;
    
    private void Start()
    {
        clueText.alpha = 0f;
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if(col.transform.tag == "Player")
        {
            clueText.alpha = 1f;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if(col.transform.tag == "Player")
        {
            clueText.alpha = 0f;
        }
    }
}
