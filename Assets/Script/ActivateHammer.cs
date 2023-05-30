using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateHammer : MonoBehaviour
{
    public HingeJoint HammerHolder;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("HammerActivator"))
        {
            // Debug.Log("triggered!");
            var limits = HammerHolder.limits;
            limits.max = 90f;
            HammerHolder.limits = limits;
        }
    }
}
