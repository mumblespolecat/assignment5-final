using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToMe : MonoBehaviour
{
    // The target marker.
    public Transform target;
    // Get the HippyKid's animator
    public Animator anim;
    public bool hasJumped = false; // this is set to stop him jumping all the time

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // the first bit checks to see if the character is more than 5 metres away from the player, so they aren't all rotating all over the place regardless
        // of how far away you are from them
        float distance = Vector3.Distance(this.transform.position, target.transform.position);  //  get the distance between the character and the player
        if (distance < 5.0f)  // then if it is closer than 5 ...
        {
            mightAsWellJump();

            // this bit sets the x and z components of target position to those of the target and the y component to that of the character, resulting in no tilt. This nearly
            // drove me round the twist for most of Sunday until Youtube came to the rescue !  Obvious really, with the benefit of hindsight ...
            Vector3 targetPosition = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
            transform.LookAt(targetPosition);
        }
    }

    void mightAsWellJump()
    {
        // Set the animation to jump like he is surprised ... JumpNow is a parameter in his animation controller
        if(!hasJumped)

        anim.SetTrigger("JumpNow");
        //anim.SetTrigger("AndBreathe");
        hasJumped = true;
    }
}