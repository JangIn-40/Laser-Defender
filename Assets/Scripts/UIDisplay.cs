using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIDisplay : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] Slider healthSlider;
    [SerializeField] Health playerHealth;

    [Header("Score")]
    [SerializeField] TextMeshProUGUI Score;
    ScoreKeeper scoreKeeper;

    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    void Start()
    {
        healthSlider.maxValue = playerHealth.GetHealth();
    }

    void Update()
    {
        if(healthSlider != null)
        {
            // healthSlider.minValue = 0;
            // healthSlider.value = health.GetHealth();
            healthSlider.value = playerHealth.GetHealth();
        }

        if(Score != null)
        {
            Score.text = scoreKeeper.GetScore().ToString("000000000");
        }
    }
}
