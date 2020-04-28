using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// -----------------------------------------------------------------------------------------------------------
// <copyright file="RestartButton.cs">
// MIT Licence Copyright (c) 2020.
// </copyright>
// <author>James Mead Heath</author>
// <summary>
// Responsible for restarting the game if the player clicks the restart button on the death screen.
// </summary>
// -----------------------------------------------------------------------------------------------------------

public class RestartButton : MonoBehaviour
{
    // The main game scene is scene one. 
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
