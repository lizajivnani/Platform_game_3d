using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class level001 : MonoBehaviour
{
    public GameObject fadeIn;
    // Start is called before the first frame update
    void Start()
    {
        redirectToLevel.levelNum = 3;
        StartCoroutine(fadeInOff());
        
    }

   IEnumerator fadeInOff()
    {
        fadeIn.SetActive(false);
        yield return new WaitForSeconds(2);
    }
}
