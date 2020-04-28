using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// -----------------------------------------------------------------------------------------------------------
// <copyright file="StartGameButton.cs">
// MIT Licence Copyright (c) 2020.
// </copyright>
// <author>James Mead Heath</author>
// <summary>
// Starts the main game from the menu.
// </summary>
// -----------------------------------------------------------------------------------------------------------

public class StartGameButton : MonoBehaviour
{
    //Scene one is the main game scene.
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
