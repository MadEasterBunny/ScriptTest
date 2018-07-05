using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        int[] points = new int[5];

        points[0] = 10;
        points[1] = 20;
        points[2] = 30;
        points[3] = 40;
        points[4] = 50;

        for (int i = points.Length - 1; i >= 0; i--)
        {
           Debug.Log(points[i]); 
        }
    }
}
