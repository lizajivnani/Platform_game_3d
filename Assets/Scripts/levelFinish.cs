using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelFinish : MonoBehaviour
{
    public GameObject levelMusic;
    public AudioSource levelEnd_audio;
    public GameObject Timer;

    public GameObject timeLeft;
    public GameObject curScore;
    public GameObject totalScore;
    int timeScore ;
    int total_score;
    public GameObject fadeOut;


    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        Timer.SetActive(false);
        levelMusic.SetActive(false);
        levelEnd_audio.Play();

        timeScore = GlobalTimer.extendScore;
        timeLeft.GetComponent<Text>().text = "Timed Score: "+timeScore + " X 100";
        
        curScore.GetComponent<Text>().text = "Your Score: " + GlobalScore.score_global;
        
        total_score = (timeScore * 100) + GlobalScore.score_global;
        totalScore.GetComponent<Text>().text = "Total Score: " + total_score;

        timeLeft.SetActive(true);
        curScore.SetActive(true);
        totalScore.SetActive(true);
        StartCoroutine(fadeOutOn());
    }

    IEnumerator fadeOutOn()
    {
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
   
    }

   }
