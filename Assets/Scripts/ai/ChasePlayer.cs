using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChasePlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;

    private NavMeshAgent agent;
    
    private void Start()
    {
        agent = this.gameObject.GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.destination = player.transform.position;
    }
}
