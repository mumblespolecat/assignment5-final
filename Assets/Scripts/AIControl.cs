using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIControl : MonoBehaviour
{
    // The clever bits in this whole script came from the Learn Unity website, so I can't lay any claim to it really and have creditied it appropriately in the ReadMe
    // and the submitted word file.  The comments are mine.
    
    GameObject[] goalLocations; // an array to hold the goal locations 
    UnityEngine.AI.NavMeshAgent agent;
    Animator anim;
    float sm;  // a float for the speed multiplier for the animation, so they don't all look like they are moving at the same rate
    
    // Start is called before the first frame update
    void Start()
    {
        goalLocations = GameObject.FindGameObjectsWithTag("goal"); // find the goals, tagged with goal
        agent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.SetDestination(goalLocations[Random.Range(0, goalLocations.Length)].transform.position);  // Pick a random goal from the array
        anim = this.GetComponent<Animator>();
        anim.SetFloat("wOffset", Random.Range(0, 1)); // wOffset is a parameter in the animator, so they don't all start at the same point in the animation
        sm = Random.Range(0.5f, 1.5f);
        anim.SetFloat("speedMult", sm);  // speedMult is also a parameter in the animator, so that the agents aren't all actually moving at the same rate
        agent.speed *= sm;
    }

    // Update is called once per frame
    void Update()
    {
        // if an agent is getting close to its goal, choose another one and turn towards it
        if(agent.remainingDistance < 1)
        {
            agent.SetDestination(goalLocations[Random.Range(0, goalLocations.Length)].transform.position);
        }
    }
}
