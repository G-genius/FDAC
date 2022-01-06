using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chechpoint : MonoBehaviour
{
    public Transform[] checkPoints;
    public int chance = 50;
    GameObject sofa;
    void Start()
    {
        sofa = GameObject.FindGameObjectWithTag("Sofa");
    }
    public Transform getNextPoint()
    {
        int rand = Random.Range(1, 100);
        if(rand <= chance)
        {
            return getPointToSofa();
        }
        return checkPoints[Random.Range(0, checkPoints.Length)];
    }

    Transform getPointToSofa()
    {
        Transform point = checkPoints[0];
        if(checkPoints.Length > 0)
        {
            float distation = Vector3.Distance(point.position, sofa.transform.position);
            for(int i = 1; i < checkPoints.Length; i++)
            {
                if(Vector3.Distance(checkPoints[i].position, sofa.transform.position) < distation)
                {
                    point = checkPoints[i];
                }
            }
        }
        return point;
    }

}
