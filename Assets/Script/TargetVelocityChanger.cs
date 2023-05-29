using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetVelocityChanger : MonoBehaviour
{

    //JointMotor jm = GetComponent<HingeJoint>().motor;
    //jm.targetVelocity *= -1;
    //GetComponent<HingeJoint>().motor = jm;

    public HingeJoint Joint;

    private void Update()
    {
        if(Input.GetKeyUp("space"))
        {
            var motor1 = Joint.motor;
            motor1.targetVelocity *= -1;
            Joint.motor = motor1;
        }
    }


}
