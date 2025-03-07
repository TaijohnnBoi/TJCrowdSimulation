using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{

    // Agents destination
    GameObject[] goalLocations;
    // Get the prefab
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        // Access the agents NavMesh
        agent = this.GetComponent<NavMeshAgent>();
        goalLocations = GameObject.FindGameObjectsWithTag("goal");
        int i = Random.Range(0, goalLocations.Length);
        agent.SetDestination(goalLocations[i].transform.position);
    }

    void Update()
    {

    }
}
