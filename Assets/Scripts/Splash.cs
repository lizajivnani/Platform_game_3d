using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{

    public GameObject logo;
    void Update()
    {

        StartCoroutine(splashLogo());
        
    }

    IEnumerator splashLogo()
    {
        logo.SetActive(true);
        yield return new WaitForSeconds(3);
        
        SceneManager.LoadScene(1);
        yield return new WaitForSeconds(2);


    }
}
