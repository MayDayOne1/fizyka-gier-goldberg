using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCar : MonoBehaviour
{
    public ConstantForce constantForce;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("CarActivator"))
        {
            Debug.Log("Engine start!");
            var force = constantForce.relativeForce;
            force.z = 1f;
            constantForce.relativeForce = force;
        }
    }
}
