using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalTimer : MonoBehaviour
{
    public GameObject timer;
    public int time_remaining = 150;
    public bool flag = false;
    public static int extendScore;
    // Update is called once per frame
    void Update()
    {
        extendScore = time_remaining;
        if (flag == false && time_remaining > 0)
        {
            StartCoroutine(subtract_seconds());
        }
    }

    IEnumerator subtract_seconds ()
    {
        flag = true;
        time_remaining -= 1;
        timer.GetComponent<Text>().text = "" + time_remaining;
         yield return new WaitForSeconds(1);
        flag = false;
    }
}
