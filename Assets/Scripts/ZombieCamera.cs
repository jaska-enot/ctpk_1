using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class ZombieActions : MonoBehaviour
{   
    [SerializeField] private GameObject human;
    [SerializeField] private NavMeshAgent agent;
    public bool isTriggered = false;

    void Update()
    {
        agent.SetDestination(human.transform.position);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == human)
        {
            isTriggered = true;
        }
    }
}
