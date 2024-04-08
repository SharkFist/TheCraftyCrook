using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform[] patrolPoints;
    public int targetPoint;
    
    private NavMeshAgent _agent;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.updateRotation = false;
        _agent.updateUpAxis = false;
        
        targetPoint = 0;
    }

    private void Update()
    {
        _agent.SetDestination(patrolPoints[targetPoint].position);
        if (transform.position == patrolPoints[targetPoint].position)
        {
            NextTargetPoint();
        }
    }

    private void NextTargetPoint()
    {
        targetPoint++;
        if (targetPoint >= patrolPoints.Length)
        {
            targetPoint = 0;
        }
    }
}
