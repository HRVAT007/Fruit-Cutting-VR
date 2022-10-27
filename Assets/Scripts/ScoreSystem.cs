using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreSystem : MonoBehaviour
{
    public int score;
    public int playerHealth = 3;
    
    void Update()
    {
        if (playerHealth <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
    }

    public void SubtractHealth(int healthToSubtract)
    {
        playerHealth -= healthToSubtract;
    }
}
