using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public int score = 0;

    public Text currentScore;

    public GameObject player;

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
    }
}
