using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Guard : MonoBehaviour
{
    [SerializeField] private Transform player;
    private NavMeshAgent agent;
    private float timer = 0f;
    private float threshold = 0.5f;
   // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //agent.destination = goal.position;

        timer += Time.deltaTime;
        if (timer >= threshold)
        {
            agent.destination = player.position;
            timer = 0f;
            transform.LookAt(player.position);
        }
         
    }

    public void setTarget(Transform newGoal)
    {
        player = newGoal;
    }
}