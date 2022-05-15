using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public static float gameTimer; //Creating a float to hold the timer, called gameTimer
    private GUIStyle guiStyle = new GUIStyle(); //  Declaring and initializing a GUIStyle object called guiStyle

    // Update is called once per frame
    void Update()
    {
        gameTimer += Time.deltaTime; // We're initializing gameTimer to be equal to Time.deltaTime
                                     // DeltaTime is incrementing gameTImer every second.

    }

    private void OnGUI() //OnGUI is a built in unity engine class
    {

        int min = Mathf.FloorToInt(gameTimer / 60F); // Initializing an int called min, that takes the gameTimer and divides it by 60 to create minutes.
        int sec = Mathf.FloorToInt(gameTimer - min * 60); // Initializing an int called sec that creates seconds
        string timeDisplay = string.Format("{0:0}:{1:00}", min, sec); //The format of the timer

        guiStyle.fontSize = 20; //Increases the fontsize of the timer to 20
        guiStyle.normal.textColor = Color.red; //Changes the font color to red
        GUI.Label(new Rect(10, 10, 250, 100), timeDisplay, guiStyle); //Creates a label with the specified dimensions to display the timer.

    }
}
