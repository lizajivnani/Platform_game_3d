using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{

    public static int score_global = 0;
    public int internal_score ;

    public GameObject scoreBox;
 
    // Update is called once per frame
    void Update()
    {


        
        internal_score = score_global;
        scoreBox.GetComponent<Text>().text = "" + internal_score;
        
    }
}
