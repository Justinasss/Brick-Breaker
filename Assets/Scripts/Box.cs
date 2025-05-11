using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Box : MonoBehaviour
{
    public int pointsOnDestroy = 100;
    public TMP_Text scoreText;
    private static int score = 0;    

    private void Start()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            score += pointsOnDestroy;
            if (scoreText != null)
            {
                scoreText.text = "Score: " + score;
            }
            Destroy(gameObject);
        }
    }
}
