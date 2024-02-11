using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int score = 0;

    public int GetScore()
    {
        return score;
    }

    public void AddScore(int enemyScore)
    {
        score += enemyScore;
        Debug.Log(score);
    }
    
    public void ResetScore()
    {
        score = 0;
    }
}
