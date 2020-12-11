using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToMeMichelle : MonoBehaviour
{
    // This script based on the HippyKid's, but a bit different
    
    // The target marker.
    public Transform michelleTarget;
    // Get Michelle's animator
    public Animator michelleAnim;

    void Start()
    {
        michelleAnim = GetComponent<Animator>();
    }

    void Update()
    {
        // checks the distance between the camera and the npc so they aren't rotating all the time
        float distance = Vector3.Distance(this.transform.position, michelleTarget.transform.position);
        if (distance < 5.0f)
        {
            MoveToIdle();

            // this bit sets the x and z components of target position to those of the target and the y component to that of the character, resulting in no tilt. This nearly
            // drove me round the twist for most of Sunday until Youtube came to the rescue !  Obvious really, with the benefit of hindsight ...
            Vector3 targetPosition = new Vector3(michelleTarget.transform.position.x, transform.position.y, michelleTarget.transform.position.z);
            transform.LookAt(targetPosition);
        }
    }

    void MoveToIdle()
    {
        // Stop Michelle mooning and get her to idle
        
        michelleAnim.SetTrigger("IdleTime");
        
    }
}