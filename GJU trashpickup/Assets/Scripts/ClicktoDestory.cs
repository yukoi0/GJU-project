using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Add this line to access Unity UI components

public class ClicktoDestory : MonoBehaviour
{
    public Text scoreText; // Reference to the UI Text component where the score will be displayed
    private int score = 0; // Variable to store the score

    private void Start()
    {
        UpdateScoreText(); // Update the score text when the game starts
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        IncreaseScore(); // Call the method to increase the score when an object is destroyed
    }

    private void IncreaseScore()
    {
        score++; // Increment the score
        UpdateScoreText(); // Update the score text
    }

    private void UpdateScoreText()
    {
        // Update the text of the UI Text component to display the current score
        scoreText.text = "Score: " + score.ToString();
    }
}
