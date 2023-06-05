using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetVelocityChanger : MonoBehaviour
{
    public HingeJoint Joint;
    // public ConstantForce constantForce;

    private void Update()
    {
        if(Input.GetKeyUp("space"))
        {
            var motor1 = Joint.motor;
            motor1.targetVelocity *= -1;
            Joint.motor = motor1;

            //var force = constantForce.relativeForce;
            //force.z = 5f;
            //constantForce.relativeForce = force;
        }
    }


}
