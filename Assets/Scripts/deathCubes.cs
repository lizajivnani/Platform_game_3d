using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathCubes : MonoBehaviour
{
    public GameObject youFell;
    public GameObject levelAudio;
    public GameObject fadeObj;

    // index number from build settings
     void OnTriggerEnter()
    {
        StartCoroutine(fell_off());
    }

    IEnumerator fell_off()
    {
        youFell.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeObj.SetActive(true);
        yield return new WaitForSeconds(2);


        levelAudio.SetActive(false);
        SceneManager.LoadScene(2);

    }


}
