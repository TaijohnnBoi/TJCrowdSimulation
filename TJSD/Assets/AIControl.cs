using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIControl : MonoBehaviour
{

    // Agents destination
    GameObject[] goalLocations;
    // Get the prefab
    UnityEngine.AI.NavMeshAgent agent;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        // Access the agents NavMesh
        agent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        goalLocations = GameObject.FindGameObjectsWithTag("goal");
        anim = this.GetComponent<Animator>();
        agent.SetDestination(goalLocations[Random.Range(0,goalLocations.Length)].transform.position);
        anim.SetTrigger("isWalking");
    }

    void Update()
    {
        if (agent.remainingDistance < 1)
        {
            agent.SetDestination(goalLocations[Random.Range(0, goalLocations.Length)].transform.position);
        }
    }
}
