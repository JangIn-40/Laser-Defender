using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIGameOver : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI scoreText;
    ScoreKeeper scoreKeeper;

    void Awake()
    {
        //FindObjectOfType을 쓸때는 hierachy에 객체가 있는지 확인하자...
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    void Start()
    {
        if(scoreText.text != null)
        {
            Debug.Log("해결좀");
            scoreText.text = "You Scored :\n" + scoreKeeper.GetScore();
        }
    }

}
