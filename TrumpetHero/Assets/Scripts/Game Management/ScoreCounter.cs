using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// -----------------------------------------------------------------------------------------------------------
// <copyright file="ScoreCounter.cs">
// MIT Licence Copyright (c) 2020.
// </copyright>
// <author>James Mead Heath</author>
// <summary>
// Keeps track of the score only when the player object is active
// Displays the score on the main game menu and the death screen
// Stops adding to the score when the player character isn't active anymore
// </summary>
// -----------------------------------------------------------------------------------------------------------

public class ScoreCounter : MonoBehaviour
{
    private int score = 0;

    public Text currentScore;
    public Text endScore;

    public GameObject player;

    public GameObject gameScreen;
    public GameObject deathScreen;

    //Starts the score count at zero
    void Start()
    {
        currentScore.text = score.ToString();
    }
 
    void OnTriggerEnter2D(Collider2D Obstacle)
    {
        //Adds to the score when the player avoids obstacles and then displays the score
        if (player.activeSelf)
        {
            score++;
            currentScore.text = score.ToString();
        }

        //Stops adding to the score and then displays the final score on the death screen.
        else
        {
            gameScreen.SetActive(false);
            deathScreen.SetActive(true);
            endScore.text = score.ToString();
        }
    }
}
