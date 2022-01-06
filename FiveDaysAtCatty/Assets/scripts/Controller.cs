using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Controller : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform checkpoint;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Invoke("Movement", 5f);
        
    }
    void Movement()
    {
        Chechpoint point = checkpoint.GetComponent<Chechpoint>();
        checkpoint = point.getNextPoint();
        agent.destination = checkpoint.position;
        Invoke("Movement", 5f);
    }
}
