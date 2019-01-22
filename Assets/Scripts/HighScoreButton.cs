using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This allows to use the scene loading function.
using UnityEngine.SceneManagement;

public class HighScoreButton : MonoBehaviour {

    // Called when the button  is clicked.
    public void GoToHighScores()
    {

        //  Return to title screen.
        SceneManager.LoadScene("HighScores");

    }
}
