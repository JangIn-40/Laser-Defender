using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int score = 0;

    static ScoreKeeper instance;

    void Awake()
    {
        ManageSingleton();
    }
    
    void ManageSingleton()
    {
        // int instanceCount = FindObjectsOfType(GetType()).Length;
        // if(instanceCount > 1)
        if(instance != null)
        {
            //희박한 확률로 Destroy하기전에 다른곳에서 게임오브젝트를 실행할수도 있다.
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    
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
