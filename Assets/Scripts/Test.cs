using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        int[] points = { 10, 20, 30, 40, 50 };

        for (int i = points.Length - 1; i >= 0; i--)
        {
           Debug.Log(points[i]); 
        }
    }
}
