using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCar : MonoBehaviour
{
    public ConstantForce constantForce;
    public Rigidbody rb;
    public float velocity = 5f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("CarActivator"))
        {
            // Debug.Log("Engine start!");
            var force = constantForce.relativeForce;
            force.z = velocity;
            constantForce.relativeForce = force;
            rb.constraints = RigidbodyConstraints.FreezePosition;
        }
    }
}
