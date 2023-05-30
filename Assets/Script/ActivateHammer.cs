using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateHammer : MonoBehaviour
{
    public HingeJoint HammerHolder;
    public GameObject Sparks;

    private void Start()
    {
        Sparks.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("HammerActivator"))
        {
            Sparks.SetActive(true);
            // Debug.Log("triggered!");
            var limits = HammerHolder.limits;
            limits.max = 90f;
            HammerHolder.limits = limits;
        }
    }
}
