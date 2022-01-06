using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Controller : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform checkpoint;
    public Transform sofa;
    bool killSofa;
    void Start()
    {
        sofa = GameObject.FindGameObjectWithTag("Sofa").transform;
        agent = GetComponent<NavMeshAgent>();
        Invoke("Movement", 3f/*100f/(Options.day + Options.mode)*/);
        
    }
    void Movement()
    {
        Chechpoint point = checkpoint.GetComponent<Chechpoint>();
        if(point is FunctionEnemy)
        {
            RaycastHit hit;
            
            if(Physics.Raycast(transform.position + transform.up, sofa.position - (transform.position + transform.up), out hit))
            {
                if(hit.collider.tag == "Sofa")
                {
                    agent.destination = hit.collider.transform.position;
                    killSofa = true;
                }
            }
        }
        else
        {
            checkpoint = point.getNextPoint();
            agent.destination = checkpoint.position;
            Invoke("Movement", 3f/*20f/Options.mode*/);
        }
    }
    void Update()
    {
        Debug.DrawRay(transform.position + transform.up, sofa.position - transform.position + transform.up);
        if (!killSofa && Vector3.Distance(transform.position, sofa.position) < 1f)
        {
            sofa.gameObject.SendMessage("Sofa was killed");
        }
    }
}
