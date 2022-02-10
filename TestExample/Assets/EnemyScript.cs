using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    public NavMeshAgent myAgent;

    public int patrolTargetNumber;
    public Transform[] patrolTargets;
    public Transform target;

    public float alertDistance = 30f;
    public bool alertOn = false;

    public LayerMask layerMask;

    // Start is called before the first frame update
    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        InvokeRepeating("CheckAlarm",0f,0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PatrolTarget")
        {
            patrolTargetNumber += 1;
        }
    }

    void CheckAlarm()
    {
        Distance();

        if(alertOn == true)
        {
            SeekPlayer();
        }

        else
        {
            Patrol();
        }
    }

    void Distance()
    {
        Debug.DrawRay(transform.position, transform.forward * 50f, Color.green, 1f);

        float dist = Vector3.Distance(transform.position, target.position);

        if ((Physics.Raycast(transform.position, transform.forward, 50f, layerMask)) || dist <= alertDistance)
        {
            alertOn = true;
        }

        else
        {
            alertOn = false;
        }
    }

    void Patrol()
    {
        if (patrolTargetNumber > patrolTargets.Length-1)
        {
            patrolTargetNumber = 0;
        }
        myAgent.destination = patrolTargets[patrolTargetNumber].position;
        myAgent.speed = 3.5f;
    }

    void SeekPlayer()
    {
        myAgent.destination = target.position;
        myAgent.speed = 6f;
    }
}
