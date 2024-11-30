using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gem_rotate : MonoBehaviour
{

    public static int rotate_speed = 1;

    // Update is called once per frame
    void Update()
    {
        // Rotating Around Y Axis
        transform.Rotate(0, rotate_speed, 0, Space.World);
    }
}
