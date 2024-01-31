using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scores : MonoBehaviour
{
    public static Scores scores;
    public int score;
    public TextMeshProUGUI textScore;

    private void Awake()
    {
        scores = this;
    }

    public void showScore()
    {
        textScore.text = score.ToString();
    }
}
