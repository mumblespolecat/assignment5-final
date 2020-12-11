using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToMeGranny : MonoBehaviour
{
    // This script based on the HippyKid's, but a bit different
    
    // The target marker.
    public Transform grannyTarget;
    // Get Granny's animator
    public Animator grannyAnim;

    void Start()
    {
        grannyAnim = GetComponent<Animator>();
    }

    void Update()
    {
        // checks the distance between the camera and the npc so they aren't rotating all the time
        float distance = Vector3.Distance(this.transform.position, grannyTarget.transform.position);
        if (distance < 5.0f)
        {
            MoveToIdle();

            // this bit sets the x and z components of target position to those of the target and the y component to that of the character, resulting in no tilt. This nearly
            // drove me round the twist for most of Sunday until Youtube came to the rescue !  Obvious really, with the benefit of hindsight ...
            Vector3 targetPosition = new Vector3(grannyTarget.transform.position.x, transform.position.y, grannyTarget.transform.position.z);
            transform.LookAt(targetPosition);
        }
    }

    void MoveToIdle()
    {
        // Stop Granny dancing and get her to idle
        
        grannyAnim.SetTrigger("IdleTime");
        
    }
}