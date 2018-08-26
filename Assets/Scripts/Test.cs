using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        int[] pointsI = { 10, 20, 30, 40, 50 };

        for(int i = 0; i < 5; i++)
        {
            Debug.Log(pointsI[i]);
        }

        int[] pointsJ = { 10, 20, 30, 40, 50 };
        for (int j = pointsJ.Length - 1; j >= 0; j--)
        {
           Debug.Log(pointsJ[j]); 
        }
    }
}
