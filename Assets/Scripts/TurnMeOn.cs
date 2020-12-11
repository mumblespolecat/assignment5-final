using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class TurnMeOn : MonoBehaviour
{
    // a public game object pointing at an empty to have the dog in it
    public GameObject dog;
    
    // the Yarn Command in Granny's yarn (this script is attached to Granny's story trigger).
    // This was a bugger to get working, until it was changed from Camel Case to lower case !
    [YarnCommand("switchon")]
    public void SwitchOn()
    {
        dog.SetActive(true);
        // Debug.Log("Dog should now be on"); // just checking
    }
}
