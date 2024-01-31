using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite spriteSmile;

    public float delay;

    public AudioSource audioSourceA;
    public AudioSource audioSourceB;

    public bool lastquestions;

    private void OnEnable()
    {
        int score = PlayerPrefs.GetInt("score");
    }

    private void Start()
    {
        PlayerPrefs.SetInt("score", 0);
    }

    public void Answers(bool answers)
    {

        if (answers)
        {
            audioSourceA.Play();
            spriteRenderer.sprite = spriteSmile;
            Invoke(nameof(NextSoal), delay);
            Scores.scores.score += 20;
            Scores.scores.showScore();
        }
        else
        {
            audioSourceB.Play();
            Invoke(nameof(SilenceSoal), delay);
        }             
    }

    public void SilenceSoal()
    {
        gameObject.SetActive(true);
    }

    public void NextSoal()
    {
        gameObject.SetActive(false);

        if (lastquestions)
        {
            return;
        }
        transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
    }
}
