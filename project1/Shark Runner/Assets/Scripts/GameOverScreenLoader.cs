using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This class loads the current points value into the Game Over screen text
public class GameOverScreenLoader : MonoBehaviour
{
    //This is a reference to a component attached to a gameobject. 
    //This should reference the "Score_Text" GameObject in the Game_Over scene and be assigned via the inspector.
    //It is marked as [SerializeField] private as we want to initialize it from the inspector but not allow other classes to access it.
    [SerializeField]
    private Text ScoreText;
    [SerializeField]
    private string endString = " Points";

    void Awake() {
        if (ScoreText != null) {
            //Sets the text field of the Text component to the current points. Doing this will update the text the component displays in the scene
            ScoreText.text = GameData.GetPoints().ToString() + endString;
        } else {
            //Debug Log strings will appear in the Unity inspector and an external log file in full builds of the game
            Debug.Log("Score Text has not been initialized");
            //Print only appears in the editor thus saves you read and write time when the project is built
            print("Score text has not been initialized");
        }
    }


}
