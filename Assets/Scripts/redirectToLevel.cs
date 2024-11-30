using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class redirectToLevel : MonoBehaviour
{

    //index number from build settings
   public static int levelNum = 1;
    void Update()
    {
        SceneManager.LoadScene(3);
    }


}
