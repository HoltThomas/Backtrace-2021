using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChasePlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;

    [SerializeField] private float dist;
    private NavMeshAgent agent;
    
    private void Start()
    {
        agent = this.gameObject.GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        dist = Vector3.Distance(this.transform.position, player.transform.position);

        if(dist < 40.0f)
        {
            agent.destination = player.transform.position;
        }
        else
        {
            agent.destination = agent.transform.position;
        }
    }
}
