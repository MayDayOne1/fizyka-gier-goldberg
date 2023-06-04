using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassCenterManager : MonoBehaviour
{
    private Rigidbody rb;
    public Transform centerOfGravity;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (centerOfGravity)
        {
            rb.centerOfMass = centerOfGravity.localPosition;
        }
    }
}
