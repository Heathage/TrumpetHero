﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    private int score = 0;

    public Text currentScore;
    public Text endScore;

    public GameObject player;

    public GameObject gameScreen;
    public GameObject deathScreen;

    void Start()
    {
        currentScore.text = score.ToString();
    }

    void OnTriggerEnter2D(Collider2D Obstacle)
    {
        if (player.activeSelf)
        {
            score++;
            currentScore.text = score.ToString();
        }

        else
        {
            gameScreen.SetActive(false);
            deathScreen.SetActive(true);
            endScore.text = score.ToString();
        }
    }
}
