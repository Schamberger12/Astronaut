using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public ScoreTracker scoreManager;

    public int pointAmount;


    private void OnCollisionEnter(Collision collision)
    {

        scoreManager.AddPoint(pointAmount);

    }
}
