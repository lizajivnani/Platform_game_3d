using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gemSilver : MonoBehaviour
{

    public AudioSource collect_Sound;

    void OnTriggerEnter()
    {
        GlobalScore.score_global += 1000;
        collect_Sound.Play();
        Destroy(gameObject);
    }

}