using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chechpoint : MonoBehaviour
{
    public Transform[] checkPoints;

    public Transform getNextPoint()
    {
        return checkPoints[Random.Range(0, checkPoints.Length)];
    }

}
